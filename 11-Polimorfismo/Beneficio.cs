
class Beneficio
{
  // Métodos
  public virtual void ValeAlimentacao(double salario) // virtual para informa que é possível sobrescrever este método
  {
    Console.WriteLine("Desconto padrão do vale alimentação R$" + salario * 0.1);
  }

  public void ValeTransporte(double salario)
  {
    Console.WriteLine("Desconto padrão do vale transporte R$" + salario * 0.06);
  }
}