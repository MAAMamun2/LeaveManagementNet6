using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.WebV2.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Numbers Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage ="The Enter A Valid Number")]        
        public int DefaultDays { get; set; }
    }
}
