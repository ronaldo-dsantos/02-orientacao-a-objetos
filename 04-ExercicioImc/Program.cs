namespace _04_ExercicioImc;

class Program
{
  static void Main(string[] args)
  {
    Pessoa pessoa = new Pessoa();

    pessoa.peso = 96;
    pessoa.altura = 1.82;
    
    pessoa.Mensagem();
  }
}
