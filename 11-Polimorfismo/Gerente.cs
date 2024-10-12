class Gerente : Beneficio
{
  // Método
    public override void ValeAlimentacao(double salario) // override para informar que estamos sobrescrevendo o método da classe beneficio
  {
    Console.WriteLine("Desconto gerente do vale alimentação R$" + salario * 0.15);
  }  
}