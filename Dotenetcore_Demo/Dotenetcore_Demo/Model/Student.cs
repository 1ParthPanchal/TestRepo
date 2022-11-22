using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dotenetcore_Demo.Model
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ? Id { get; set; }

        
        public string? FistName { get; set; }
        public string? LastName { get; set; }
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }
        public string OrderBy { get; set; } 
    }
}
