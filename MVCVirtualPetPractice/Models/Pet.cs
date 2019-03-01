using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPetPractice.Models
{
    public class Pet
    {
        public int Id { get; set; }
        /*[Required(ErrorMessage ="Entry is required, foo")]*/

        [Display(Name="Pet Name.")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
