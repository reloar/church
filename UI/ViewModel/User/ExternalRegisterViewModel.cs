using System.ComponentModel.DataAnnotations;

namespace UI
{
    public class ExternalRegisterViewModel
    {
        [Required]
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Picture { get; set; }
    }
}