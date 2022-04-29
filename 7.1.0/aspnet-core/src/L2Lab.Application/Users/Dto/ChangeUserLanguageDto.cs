using System.ComponentModel.DataAnnotations;

namespace L2Lab.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}