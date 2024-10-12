class Pessoa // Classe principal
{
  // Atributos Protegidos (somente a classe que ele é criado e as classe que herdam tem acesso)
  protected string nome;
  protected int idade;

  // Método Protegido (somente a classe que ele é criado e as classe que herdam tem acesso)
  protected void MensagemPessoa()
  {
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Idade: " + idade);
  }
}