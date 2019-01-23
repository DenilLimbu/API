using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Model
{
    public class Search
    {
        [Required]
        public string searchCriteria { get; set; }

        [Required]
        public int limit { get; set; }

        [Required]
        public string ordreBy{get; set;}

        [Required]
        public Gender StudentGender { get; set; }

        public enum Gender
        {
            Male,
            Female
        }
    }
}
