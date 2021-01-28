namespace BookApi.Models
{
    public interface IBookStoreDatabaseSettings {
        string collectionName { get; set; }
        string connectionString { get; set; }
        string databaseName { get; set; }
    }
    public class BookStoreDatabaseSettings : IBookStoreDatabaseSettings
    {
        public string collectionName { get; set; }
        public string connectionString { get; set; }
        public string databaseName { get; set; }
    }
}