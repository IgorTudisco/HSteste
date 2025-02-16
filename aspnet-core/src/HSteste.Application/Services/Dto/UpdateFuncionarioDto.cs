namespace HSteste.Application.Services.Dto
{
  public class UpdateFuncionarioDto
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    public string Cep { get; set; }
    public string Cargo { get; set; }
    public string Setor { get; set; }
    public string Empresa { get; set; }
    public string DataAdmissao { get; set; }
    public string DataDemissao { get; set; }
    public string Status { get; set; }
  }
}