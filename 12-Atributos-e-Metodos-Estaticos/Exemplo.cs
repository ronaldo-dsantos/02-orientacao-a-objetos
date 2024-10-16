/*
  Atributos e Métodos Estáticos
  Os atributos e métodos estáticos servem para que você possa utilizá-los sem a necessidade de instanciar um objeto
*/
class Exemplo
{
  // Atributo estático
  public static string nome = "Ronaldo"; // static significa que você vai poder ter acesso a este método sem a necessidade de instanciar um objeto

  // Método estático
  public static void Soma(int n1, int n2) // static significa que você vai poder ter acesso a este método sem a necessidade de instanciar um objeto
  {
    Console.WriteLine(n1 + n2);
  }
}