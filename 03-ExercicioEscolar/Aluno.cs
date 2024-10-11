class Aluno
{
  // Atributos
  public string nome;
  public double nota01, nota02;

  // Métodos
  public double Media()
  {
    return (nota01 + nota02) / 2;
  }

  public string Situacao(double media)
  {
    return media >= 7 ? "aprovado" : "reprovado";
  }

  public void Mensagem()
  {
    var media = Media();
    var situacao = Situacao(media);

    Console.WriteLine(nome + " está " + situacao + " com a média de " + media + ".");
  }
}