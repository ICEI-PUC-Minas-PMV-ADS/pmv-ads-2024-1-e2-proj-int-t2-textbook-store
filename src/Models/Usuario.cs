using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaLivros.Models;

[Table("usuarios")]
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o nome.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o e-mail")]
    public string Email { get; set; }

    [Required(ErrorMessage = "É obrigatório informar a senha")]
    public string Senha { get; set; }
}
