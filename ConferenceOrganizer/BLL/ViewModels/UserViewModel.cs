using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BLL.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required]
        public int[] EditableConferenceIds { get; set; }
    }
}