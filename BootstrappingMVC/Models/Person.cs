using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrappingMVC.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        [UIHint("BooleanButtonLabel")]
        public bool LikesMusic { get; set; }
        public ICollection<string> Skills { get; set; }
    }
}