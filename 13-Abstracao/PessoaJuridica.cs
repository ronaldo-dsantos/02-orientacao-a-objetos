class PessoaJuridica : Padrao
{
  // Implementando o método obrigarório
  public override void TaxaEmprestimo(double valor)
  {
    Console.WriteLine("Taxa de empréstimo para Pessoa Jurídica R$ " + (valor * 0.2));
  }
}