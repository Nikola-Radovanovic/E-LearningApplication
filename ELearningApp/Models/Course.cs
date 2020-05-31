using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ELearningApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELearningApp.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv kursa")]
        [MaxLength(100)]
        [Display(Name = "Naziv kursa")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Unesite link kursa")]
        [MaxLength(300)]
        [Display(Name = "Link")]
        public string Link { get; set; }

        [Required(ErrorMessage = "Unesite opis kursa")]
        [MaxLength(300)]
        [Display(Name = "Detalji o kursu")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Izaberite nivo kursa")]
        [Display(Name = "Nivo")]
        public string Level { get; set; }

        [Required(ErrorMessage = "Izaberite kategoriju")]
        [Display(Name = "Kategorija")]
        public string[] Categories { get; set; }
    }

    public enum Level
    {
        Beginner,
        Intermediate,
        Advanced,
        Expert
    }
}
