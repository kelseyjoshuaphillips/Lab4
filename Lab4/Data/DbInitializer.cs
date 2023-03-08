namespace Lab4.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NewsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }

}
