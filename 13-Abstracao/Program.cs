namespace _13_Abstracao;

class Program
{
  static void Main(string[] args)
  {
    PessoaFisica pessoaFisica = new PessoaFisica();
    PessoaJuridica pessoaJuridica = new PessoaJuridica();

    pessoaFisica.TaxaEmprestimo(1000);
    pessoaJuridica.TaxaEmprestimo(1000);
  }
}
