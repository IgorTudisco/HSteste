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
  dataAdmissao?: string;
  dataDemissao?: string;
  status?: string;

  constructor(init?: Partial<Funcionario>) {
    Object.assign(this, init);
  }
}
