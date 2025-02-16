using Abp.Application.Services.Dto;

namespace HSteste.Application.Services.Dto
{
  public class GetFuncionarioDto : EntityDto<int>
  {
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal Salario { get; set; }
  }
}