class Pessoa
{
  // Método 01
  public void Apresentar()
  {
    Console.WriteLine("Olá!!!");
  }

  // Método 02
  public void Apresentar(string nome) // Você pode ter mais que um método com o mesmo nome desde que ele tenha parametros diferentes
  {
    Console.WriteLine("Olá " + nome + "!");
  }

  // Método 03
  public void Apresentar(string nome, int idade)
  {
    Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos.");
  }
}