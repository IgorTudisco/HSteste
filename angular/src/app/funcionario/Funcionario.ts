export class Funcionario {
  id?: number;
  nome?: string;
  cpf?: string;
  email?: string;
  telefone?: string;
  endereco?: string;
  cep?: string;
  cidade?: string;
  estado?: string;
  pais?: string;
  cargo?: string;
  setor?: string;
  salario?: number;
  dataAdmissao?: Date;
  dataDemissao?: Date;
  status?: string;

  constructor(init?: Partial<Funcionario>) {
    if (init) {
      this.id = init.id;
      this.nome = this.validarNome(init.nome);
      this.cpf = this.validarCpf(init.cpf);
      this.email = this.validarEmail(init.email);
      this.telefone = this.validarTelefone(init.telefone);
      this.endereco = init.endereco;
      this.cep = this.validarCep(init.cep);
      this.cidade = init.cidade;
      this.estado = init.estado;
      this.pais = init.pais;
      this.cargo = init.cargo;
      this.setor = init.setor;
      this.salario = this.validarSalario(init.salario);
      this.dataAdmissao = this.validarData(init.dataAdmissao);
      this.dataDemissao = this.validarData(init.dataDemissao);
      this.status = init.status;
    }
  }

  // Validação de Nome (mínimo 3 caracteres)
  private validarNome(nome?: string): string {
    if (!nome || nome.trim().length < 3) {
      throw new Error("Nome inválido! Deve ter pelo menos 3 caracteres.");
    }
    return nome;
  }

  // Validação de CPF (Formato: 000.000.000-00)
  private validarCpf(cpf?: string): string {
    const cpfRegex = /^\d{3}\.\d{3}\.\d{3}-\d{2}$/;
    if (!cpf || !cpfRegex.test(cpf)) {
      throw new Error("CPF inválido! Formato esperado: 000.000.000-00.");
    }
    return cpf;
  }

  // Validação de Email (Formato válido)
  private validarEmail(email?: string): string {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!email || !emailRegex.test(email)) {
      throw new Error("E-mail inválido! Formato esperado: exemplo@dominio.com.");
    }
    return email;
  }

  // Validação de Telefone (Formato: (00) 00000-0000 ou (00) 0000-0000)
  private validarTelefone(telefone?: string): string {
    const telefoneRegex = /^\(\d{2}\) \d{4,5}-\d{4}$/;
    if (!telefone || !telefoneRegex.test(telefone)) {
      throw new Error("Telefone inválido! Formato esperado: (00) 00000-0000.");
    }
    return telefone;
  }

  // Validação de CEP (Formato: 00000-000)
  private validarCep(cep?: string): string {
    const cepRegex = /^\d{5}-\d{3}$/;
    if (!cep || !cepRegex.test(cep)) {
      throw new Error("CEP inválido! Formato esperado: 00000-000.");
    }
    return cep;
  }

  // Validação de Salário (Deve ser um número maior que zero)
  private validarSalario(salario?: number): number | undefined {
    if (salario !== undefined && (isNaN(salario) || salario <= 0)) {
      throw new Error("Salário inválido! Deve ser um número positivo.");
    }
    return salario;
  }

  // Validação de Datas (Deve ser válida)
  private validarData(data?: Date | string): Date | undefined {
    if (!data) return undefined;
    const date = typeof data === "string" ? new Date(data) : data;
    if (isNaN(date.getTime())) {
      throw new Error("Data inválida!");
    }
    return date;
  }
}
