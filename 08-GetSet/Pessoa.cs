class Pessoa
{
  /*
    Get e Set
    Get para pegar um dado e set para setar um dado
    O método Get e Set permite que você possa setar ou pegar um valor de um atributo, sem ter que deixar o atributo público
    O método Get e Set sempre vai ser público
    É possível deixar só o método Get ou só o método Set disponível para a aplicação 
  */

  // Atributo nome privado
  private string nome;

  // Método Get e Set público
  public string Nome
  {
    get { return nome; }
    set { nome = value; }
  }
}