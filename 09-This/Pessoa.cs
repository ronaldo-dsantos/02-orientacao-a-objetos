class Pessoa
{
  /*
    This
    O This é utilizado para referenciar uma atributo da classe
    Neste exeplo temos um atributo nome e um parametro nome, por padrão quando é utilizado só o nome se trata de um parametro, quando é utilizado o this se trata de um atributo da própria classe

  */

  // Atributo privado
  private string nome = "Pedro";

  // Construtor recebendo um nome por parametro
  public Pessoa(string nome)
  {
    Console.WriteLine(nome); // Exibindo o nome recebido por parametro

    Console.WriteLine(this.nome); // Exibido o atributo nome da classe
  }
}