using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.Models
{
    public class School
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv škole")]
        [Display(Name = "Naziv škole")]
        public string Name { get; set; }

        public string Courses { get; set; }

        //public string [] Courses { get; set; }
    }
}
