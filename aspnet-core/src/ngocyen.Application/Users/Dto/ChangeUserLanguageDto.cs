using System.ComponentModel.DataAnnotations;

namespace ngocyen.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}