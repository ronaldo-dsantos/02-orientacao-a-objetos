namespace _01_Conceitos;

class Program
{
  static void Main(string[] args)
  {
    // Instanciar um objeto
    Pessoa obj = new Pessoa();

    obj.nome = "Ronaldo";
    obj.idade = 39;
    obj.mensagem();
  }
}
