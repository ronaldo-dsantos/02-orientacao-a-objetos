class Aluno
{
  // Atributos privados
  private double nota01, nota02;

  // Método privado
  private double Media()
  {
    return (nota01 + nota02) / 2;
  }

  // Método público
  public void Mensagem()
  {
    Console.Write("Informe a primeira nota: ");
    nota01 = Double.Parse(Console.ReadLine());

    Console.Write("Informe a segunda nota: ");
    nota02 = Double.Parse(Console.ReadLine());

    Console.WriteLine("A média é " + Media());
  }
}