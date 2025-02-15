using System.ComponentModel.DataAnnotations;

namespace HSteste.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}