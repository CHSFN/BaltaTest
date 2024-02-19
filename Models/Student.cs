using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaltaTest.Models;


    public class Student
{
    [DisplayName("id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
    [DisplayName("nome completo")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe um email!")]
    [EmailAddress(ErrorMessage = "Informe um email válido")]
    [DisplayName("Email")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiuns { get; set; } = new();

}