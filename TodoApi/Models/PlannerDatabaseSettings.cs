namespace TodoApi.Models
{
    public class PlannerDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string TodoCollectionName { get; set; } = null!;

    }
}
