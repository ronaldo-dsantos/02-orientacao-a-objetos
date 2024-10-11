class Pessoa
{
  /*
    Construtor

    Construtor é um método que tem o mesmo nome da classe que ele pertence e é executado assim que você instancia o objeto
    Todo método construtor é público
  */

  // Método Construtor
  public Pessoa()
  {
    Console.WriteLine("Método construtor executado!");
  }

  // Método Construtor recebendo um parâmetro
  public Pessoa(string nome) // Podemos ter vários construtores desde que tenham características diferentes
  {
    Console.WriteLine("Olá " + nome + "!");
  }
}