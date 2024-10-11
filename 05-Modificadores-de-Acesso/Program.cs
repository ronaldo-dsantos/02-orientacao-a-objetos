namespace _05_Modificadores_de_Acesso;

class Program
{
    static void Main(string[] args)
    {
      Produto produto = new Produto();

      produto.nome = "Mouse";
      // produto.valor = 29,9; Não conseguimos acessar porque é um atributo privado
    }
}
