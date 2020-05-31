using ELearningApp.API.Settings;
using ELearningApp.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.API.Services
{
    public class AdminService
    {
        private readonly IMongoCollection<Admin> _admin;

        public AdminService(IE_LearningDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _admin = database.GetCollection<Admin>(settings.AdminCollectionName);
        }

        // GET /api/courses
        public List<Admin> Get() =>
            _admin.Find(a => true).ToList();

        // GET /api/courses/{id}
        public Admin Get(string id) =>
            _admin.Find(a => a.Id == id).FirstOrDefault();

        // POST
        public Admin Create(Admin admin)
        {
            _admin.InsertOne(admin);
            return admin;
        }

        // PUT
        public void Update(string id, Admin admin) =>
            _admin.ReplaceOne(a => a.Id == id, admin);

        //DELETE
        public void Remove(Admin adminIn) =>
            _admin.DeleteOne(a => a.Id == adminIn.Id);

        public void Remove(string id) =>
            _admin.DeleteOne(a => a.Id == id);
    }
}
