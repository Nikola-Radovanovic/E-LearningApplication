using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ELearningApp.HttpClients
{
    public class CourseHttp
    {
        public HttpClient Client { get; }

        public CourseHttp(HttpClient client)
        {
            client.BaseAddress = new Uri($"/api/Courses");
            Client = client;
        }
    }
}
