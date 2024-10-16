class PessoaFisica : Padrao
{
  // Implementando o método obrigarório, se não implementá-lo, teremos um erro na compilação
  public override void TaxaEmprestimo(double valor) // override para sobrescrever o método e assim criar a regra de negócio
  {
    Console.WriteLine("Taxa de empréstimo para Pessoa Física R$ " + (valor * 0.1));
  }
}