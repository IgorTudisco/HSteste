using Abp.Application.Services.Dto;

namespace HSteste.Application.Services.Dto
{
  public class DeleteFuncionarioDto
  {
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal Salario { get; set; }
  }
}