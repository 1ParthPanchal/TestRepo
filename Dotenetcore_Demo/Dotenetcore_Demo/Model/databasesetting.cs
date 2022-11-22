namespace Dotenetcore_Demo.Model
{
    public class DatabaseSetting
    {
        public string? ConnectionString { get; set; } 
        public string? DatabaseName { get; set; } 

        public string? CollectionName { get; set; } 
        public string? StripeApiKey { get; set; }   
    }
}
