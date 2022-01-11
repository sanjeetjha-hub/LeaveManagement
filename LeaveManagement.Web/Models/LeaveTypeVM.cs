using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name="Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name="Default number of days ")]
        [Required]
        [Range(1,25,ErrorMessage ="Please Enter A Number between 1 to 25")]
        public int DefaultDays { get; set; }
    }
}
