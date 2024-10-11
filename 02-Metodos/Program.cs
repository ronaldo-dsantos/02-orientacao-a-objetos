namespace _02_Metodos;

class Program
{
    static void Main(string[] args)
    {
      Pessoa obj = new Pessoa();

      obj.Apresentar();
      obj.Apresentar("Ronaldo");
      obj.Apresentar("Ronaldo", 39);
    }
}
