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
        public string[] Level { get; set; }

        [Required(ErrorMessage = "Izaberite kategoriju")]
        [Display(Name = "Kategorija")]
        public string[] Categories { get; set; }

        [Required(ErrorMessage = "Izaberite školu")]
        [Display(Name = "Škola")]
        public string[] School { get; set; }
    }

    public enum Level
    {
        Beginner,
        Intermediate,
        Advanced,
        Expert
    }

    public enum Schools
    {
        MIT,
        Hardvard,
        Berkley,
        Caltech,
        Columbia_University,
        Boston_University
    }

    public enum Categories
    {
        Web_Development,
        Game_Development,
        Mobile_Development,
        Data_Science,
        Computer_Science,
        Machine_Learning,
        Web_Design,
        Sowtvare_Engineering,
        Programming_Languages
    }
}
