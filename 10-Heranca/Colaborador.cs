/*
  Herança
  Herança é a funcionalidade de uma classe herdar atributos e métodos de outra classe
  Neste exemplo utilizamos um cenário de empresa que o colaborador tem informações pessoais e profissionais, para não fazer uma única classe cheia de atributos e métodos, separamos os contextos em classes  
*/

class Colaborador : Pessoa // Classe Colaborador herdando a classe Pessoa
{
  // Atributos Privados
  private double salario;

  // Construtor
  public Colaborador(string nome, int idade, double salario)
  {
    this.nome = nome; // Devido a herança conseguimos acessar esse atributo da classe pessoa
    this.idade = idade;
    this.salario = salario;

    MensagemPessoa(); // Devido a herança conseguimos acessar esse método da classe pessoa
    MensagemColaborador();
  }

  // Método Privado
  private void MensagemColaborador()
  {
    Console.WriteLine("Salário: " + salario);
  }
}