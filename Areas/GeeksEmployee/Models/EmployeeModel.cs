using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5Tutorial.Areas.GeeksEmployee.Models
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "Employee ID is required")]
        public int EmployeeID { get; set; }

        [StringLength(10, ErrorMessage = "The length of First Name should be less than or equal to five characters.")]     
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.
                            \w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
    }
}
