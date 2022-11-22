using Microsoft.EntityFrameworkCore;
using Dotenetcore_Demo.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

namespace Dotenetcore_Demo
{
    public class OwnerRepo
    {
        public readonly IMongoCollection<OwnersParameters?> _owner;
        //public OwnersService(IOptions<DatabaseSetting> databsesettings)
        //{
        //    var mongoClient = new MongoClient(databsesettings.Value.ConnectionString);
        //    var mongoDataBase = mongoClient.GetDatabase(databsesettings.Value.DatabaseName);
        //   _owner = mongoDataBase.GetCollection<OwnersParameters?>(databsesettings.Value.CollectionName);
       
        //}
        //public IEnumerable<OwnersParameters> GetOwners(OwnersParameters PageNumber)
        //{
        //    return FindAll
        //}
    }
}
