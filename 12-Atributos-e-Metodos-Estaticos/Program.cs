namespace _12_Atributos_e_Metodos_Estaticos;

class Program
{
  static void Main(string[] args)
  {
    Exemplo.Soma(3, 7); // Utilizando um método estático sem instanciar um objeto

    Console.WriteLine("Olá " + Exemplo.nome); // Utilizando um atributo estático sem instanciar um objeto
  }
}
