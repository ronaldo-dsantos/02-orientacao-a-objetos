class Atendente : Beneficio
{
  // Método
  public override void ValeAlimentacao(double salario) // override para informar que estamos sobrescrevendo o método da classe beneficio
  {
    Console.WriteLine("Desconto atendente do vale alimentação R$" + salario * 0.12);
  }
}