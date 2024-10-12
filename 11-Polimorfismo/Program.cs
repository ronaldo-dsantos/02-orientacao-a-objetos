/*
  Polimorfismo
  Polimorfismo é a possibilidade reutilizar um mesmo método de maneira diferentes em outras classes
  Neste exemplo sobrescremos o método ValeAlimentacao da classe Beneficios, na classe Gerente e Atendente, alterando o percentual de cálculo de acordo com o cargo
*/

namespace _11_Polimorfismo;

class Program
{
  static void Main(string[] args)
  {
    // Objeto estagiario com acesso aos métodos da casse benefício
    Beneficio estagiario = new Estagiario(); // Instanciando o objeto Estagiário e informando que ele terá acesso aos métodos da classe Benefício, caso a classe Estagiario tenha algum método com o mesmo nome da classe Beneficios ele vai reescrever o método e caso a classe estagiario tenha algum método que a classe beneficio não tenha, esse método também estará disponível atraves do objeto estagiario
    estagiario.ValeAlimentacao(1000);
    estagiario.ValeTransporte(1000);
    Console.WriteLine("-------------------");

    Beneficio atendente = new Atendente();
    atendente.ValeAlimentacao(2000);
    atendente.ValeTransporte(2000);
    Console.WriteLine("-------------------");

    Beneficio gerente = new Gerente();
    gerente.ValeAlimentacao(5000);
    gerente.ValeTransporte(5000);
    Console.WriteLine("-------------------");
  }
}