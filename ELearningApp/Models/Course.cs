using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv kursa")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Unesite link kursa")]
        [MaxLength(300)]
        public string Link { get; set; }

        [Required(ErrorMessage = "Unesite opis kursa")]
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
