class Calculo : IPadrao // Implementando a interface IPadrao
{
  // Implementando os métodos obrigatórios da Interface
  public void Somar(int n1, int n2) // Aqui pode ser definido a visibilidade de método
  {
    Console.WriteLine("A soma é " + (n1 + n2)); // Inserindo a regra de negócio
  }

  public void Subtrair(int n1, int n2)
  {
    Console.WriteLine("A subtração é " + (n1 - n2));
  }
}