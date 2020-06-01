using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required(ErrorMessage ="Unesite email")]
        [EmailAddress(ErrorMessage = "Unesite validan email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Unesite lozinku")]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Lozinka mora imati najmanje 8 karaktera, mora da sadrzi najmanje 3 od 4 stavke: velika slova (A-Z), mala slova (a-z), broj (0-9) i specijalne karaktere (!@#$%^&*)")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Unesite lozinku")]
        [DataType(DataType.Password)]
        [Display(Name = "Potvrdite lozinku")]
        [Compare("Password", ErrorMessage = "Unesite istu lozinku")]
        public string ConfirmPassword { get; set; }

    }
}
