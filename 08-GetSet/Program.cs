namespace _08_GetSet;

class Program
{
  static void Main(string[] args)
  {
    Pessoa pessoa = new Pessoa();

    pessoa.Nome = "Ronaldo"; // Usando o Set para setar o nome 

    Console.WriteLine(pessoa.Nome); // Usando o Get para pegar o nome
  }
}
