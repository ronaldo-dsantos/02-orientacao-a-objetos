namespace _14_Interface;

class Program
{
  static void Main(string[] args)
  {
    // Instanciando a classe Calculo
    Calculo calculo = new Calculo();

    // Utilizando os métodos da classe cálculo implementados pela interface
    calculo.Somar(10, 15);
    calculo.Subtrair(50, 18);
  }
}
