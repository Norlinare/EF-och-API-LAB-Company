namespace Company.API.Extensions
{
    public static class HttpExtensions
    {
        public static async Task<IResult> HttpGet<TEntity, TDto>(this IDbService db)
            where TEntity : class, IEntity
            where TDto : class =>
             Results.Ok(await db.GetAsync<TEntity, TDto>());


        public static async Task<IResult> HttpGet<TEntity, TDto>(this IDbService db, int id)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entity = await db.SingleAsync<TEntity, TDto>(e => e.Id.Equals(id));
            return Results.Ok(entity);
        }


        public static async Task<IResult> HttpPost<TEntity, TDto>(this IDbService db, TDto dto)
            where TEntity : class, IEntity
            where TDto : class
        {
            if (dto is null) return Results.BadRequest();

            var entity = await db.AddAsync<TEntity, TDto>(dto);


            if (await db.SaveChangesAsync())
            {
                var node = typeof(TEntity).Name.ToLower();
                return Results.Created($"/{node}s/{entity.Id}", entity);
            }

            return Results.BadRequest();
        }

        public static async Task<IResult> HttpPut<TEntity, TDto>(this IDbService db, int id, TDto dto)
            where TEntity : class, IEntity
            where TDto : class
        {
            if (dto is null) return Results.BadRequest();

            if (!await db.AnyAsync<TEntity>(e => e.Id.Equals(id))) 
                return Results.NotFound();

            db.Update<TEntity, TDto>(id, dto); 

            if (await db.SaveChangesAsync()) 
                return Results.NoContent();

            return Results.BadRequest();
        }

        public static async Task<IResult> HttpDelete<TEntity>(this IDbService db, int id)
            where TEntity : class, IEntity
        {
            try
            {
                var success = await db.DeleteAsync<TEntity>(id);

                if (success && await db.SaveChangesAsync()) //
                    return Results.NoContent();
            }
            catch
            {
            }
            return Results.BadRequest();
        }




        public static async Task<IResult> HttpPostToRefEntity<TReferenceEntity, TDto>(this IDbService db, TDto dto)
            where TReferenceEntity : class, IReferenceEntity
            where TDto : class
        {
            if (dto is null) return Results.BadRequest();

            var entity = await db.AddAsyncRefEntity<TReferenceEntity, TDto>(dto);


            if (await db.SaveChangesAsync())
            {
                var node = typeof(TReferenceEntity).Name.ToLower();
                return Results.Created($"/{node}s/{dto}", entity);
            }

            return Results.BadRequest();
        }


        public static async Task<IResult> HttpDeleteFromRefEntity<TReferenceEntity, TDto>(this IDbService db, TDto dto)
            where TReferenceEntity : class, IReferenceEntity
            where TDto : class
        {
            try
            {
                var success =  db.Delete<TReferenceEntity, TDto>(dto);

                if (success && await db.SaveChangesAsync())
                    return Results.NoContent();
            }
            catch
            {
            }
            return Results.BadRequest();
        }








    }
}
