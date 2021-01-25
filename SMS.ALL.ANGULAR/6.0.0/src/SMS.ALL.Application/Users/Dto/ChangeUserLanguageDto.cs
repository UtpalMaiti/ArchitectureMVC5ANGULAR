using System.ComponentModel.DataAnnotations;

namespace SMS.ALL.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}