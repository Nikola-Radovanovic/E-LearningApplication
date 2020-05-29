using ELearningApp.Models;
using ELearningApp.API.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.API.Services
{
    public class CourseService
    {
        private readonly IMongoCollection<Course> _courses;

        public CourseService(IE_LearningDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _courses = database.GetCollection<Course>(settings.CoursesCollectionName);
        }

        // GET /api/courses
        public List<Course> Get() =>
            _courses.Find(c => true).ToList();

        // GET /api/courses/{id}
        public Course Get(string id) =>
            _courses.Find(c => c.Id == id).FirstOrDefault();

        // POST
        public Course Create(Course course)
        {
            _courses.InsertOne(course);
            return course;
        }

        // PUT
        public void Update(string id, Course course) =>
            _courses.ReplaceOne(c => c.Id == id, course);

        //DELETE
        public void Remove(Course courseIn) =>
            _courses.DeleteOne(c => c.Id == courseIn.Id);

        public void Remove(string id, Course courseIn) =>
            _courses.DeleteOne(c => c.Id == id);
    }
}
