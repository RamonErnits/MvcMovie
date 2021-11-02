using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Actors
    {
        public int id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        public string Gender { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string HomeTown { get; set; }

    }
}
