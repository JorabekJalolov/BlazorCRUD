using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_CRUD.Data.Models.ViewModel
{
    public class AddEmployee
    {
        [Required]
        public string EmployeName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Designation { get; set; }
    }
}
