using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HSteste.Core.Models
{

  [Table("Funcionarios")]
  public class Funcionario : Entity
  {
    [Key]
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Endereco { get; set; }
    public string? Cep { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Pais { get; set; }
    public string? Cargo { get; set; }
    public string? Setor { get; set; }
    public string? Salario { get; set; }
    public string? DataAdmissao { get; set; }
    public string? DataDemissao { get; set; }
    public string? Status { get; set; }
  }
}