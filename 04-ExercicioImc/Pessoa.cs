using System.Xml.Serialization;

class Pessoa
{
  // Atributos
  public double peso;
  public double altura;

  // Métodos
  public double CalculaImc()
  {
    var imc = peso / (altura * altura);
    return imc;
  }

  public string Situacao(double imc)
  {
    if (imc < 18.5)
    {
      return "abaixo do peso";
    }
    else if (imc < 25)
    {
      return "peso normal";
    }
    else if (imc < 30)
    {
      return "acima do peso";
    }
    else if (imc < 35)
    {
      return "obesidade I";
    }
    else if (imc < 40)
    {
      return "obesidade II";
    }
    else
    {
      return "obesidade III";
    }
  }

  public void Mensagem()
  {
    var imc = CalculaImc();
    var faixaImc = Situacao(imc);

    Console.WriteLine("Seu IMC é de " + imc.ToString("0.0") + " e a sutiação é " + faixaImc + ".");
  }
}