namespace Astra_MK1.Data
{
    public static class prepMasterData
    {
        public static void pumpData(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                seedMasterData(serviceScope.ServiceProvider.GetService<astraDbContext>());
                seedReferenceData(serviceScope.ServiceProvider.GetService<astraDbContext>());
            }

        }

        private static void seedMasterData(astraDbContext dbContext)
        {
            if(!dbContext.mdActorTypes.Any())
            {
                
            }

        }
        private static void seedReferenceData(astraDbContext dbContext)
        {

        }
    }
}