using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Customer_invitation_Project.Models
{
    public class Answer
    {
        [Required (ErrorMessage = "Please fill in the Name section")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill in the Lastname section")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please fill in the Email section")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please fill in the Phone section")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Please make a choice")]
        public bool? ComeorNot { get; set; }

    }
}
