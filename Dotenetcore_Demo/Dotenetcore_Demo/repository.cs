using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Dotenetcore_Demo.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Dotenetcore_Demo
{
    public class StudentService
    {
        private readonly IMongoCollection<Student> _students;
        //private readonly IMongoCollection<OwnersParameters>;
        private readonly IMongoCollection<StripeDataPerameters> _stripe;
        public StudentService(IOptions<DatabaseSetting> databsesettings)
        {
            var mongoClient = new MongoClient(databsesettings.Value.ConnectionString);
            var mongoDataBase = mongoClient.GetDatabase(databsesettings.Value.DatabaseName);
            _students = mongoDataBase.GetCollection<Student>(databsesettings.Value.CollectionName);
        }
        //public StripeService(IOptions<DatabaseSetting> databsesettings)
        //{
        //    var mongoClient = new MongoClient(databsesettings.Value.ConnectionString);
        //    var mongoDataBase = mongoClient.GetDatabase(databsesettings.Value.DatabaseName);
        //    _stripe = mongoDataBase.GetCollection<StripeDataPerameters>(databsesettings.Value.CollectionName);
        //}


        public async Task<List<Student>> GetAsync()
        {
            return await _students.Find(_ => true).ToListAsync();
        }
        public async Task<Student?> GetAsync(string Id)
        {
            return await _students.Find(x => x.Id == Id).FirstOrDefaultAsync();
        }
        public IEnumerable<Student?> GetAsyncPage(Student stu)
        {
            return _students.Find(x => x.PageNumber == stu.PageNumber).Skip((stu.PageNumber - 1) * stu.PageSize).ToList();




            //await _students.Find(X => X.PageNumber == PageNumber).FirstOrDefaultAsync();
        }
        public async Task AddAsync(Student newStudent)
        {
            await _students.InsertOneAsync(newStudent);
        }
        public async Task UpdateAsync(string Id, Student updateStudent)
        {
            await _students.ReplaceOneAsync(x => x.Id == Id, updateStudent);
        }
        public async Task removeAsync(string Id)
        {
            await _students.DeleteOneAsync(x => x.Id == Id);
        }
        //public async Task<OwnersParameters?> Get(OwnersParameters PageNumber)
        //{
        //    return await _owner.Find(x => x.PageNumber == PageNumber).FirstOrDefault();
        //}
    }
    //public interface IRepository<TEntity> where TEntity : class
    //{
    //    List<TEntity> Get();
    //    TEntity GetById(int id);
    //    TEntity Add(TEntity entity);
    //    TEntity Delete(TEntity entity);
    //    TEntity Update(TEntity entity);
    //}
    //public class Repository<T> : IRepository<T> where T : class
    //{
    //    public Student student;
    //    public Repository(Student student)
    //    {
    //        this.student = student;
    //    }
    //    public async Task<List<T>> Get()
    //    {
    //        return await student.Set
    //    }
    //}
}
