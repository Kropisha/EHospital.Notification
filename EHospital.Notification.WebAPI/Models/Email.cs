using System.ComponentModel.DataAnnotations;

namespace EHospital.Notification.Model
{
    public class Email
    {
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email;

        [Required(ErrorMessage = "The field should not be empty.")]
        [StringLength(100, ErrorMessage = "No more than 100 symbols.")]
        public string topic;

        [Required(ErrorMessage = "The field should not be empty.")]
        [StringLength(1000, ErrorMessage = "No more than 1000 symbols.")]
        public string text;
    }
}
