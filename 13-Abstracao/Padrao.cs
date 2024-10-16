/*
  Abstração
  Quando você cria uma classe abstrata, significa que você está criando um padrão para seus projetos
  Uma classe abstrata pode conter métodos obrigatórios e metodos opcionais  
  Não é possível instanciar uma classe abstrata 
  Cada classe pode herdar apenas uma classe abstrata
*/

// Classe Abstrata
abstract class Padrao
{
  // Método Obrigatório (O método obrigatório sempre deve ser público ou protegido, porque as classes que hedarem serão obrigadas a implementá-lo)
  public abstract void TaxaEmprestimo(double valor); // Neste exemplo não usamos as {} porque a regra de negócio vai ficar nas classes que herdarem a classe abstrata, só estamos informando que vai ser obrigatório implementar este método conforme informado nesta classe

  // Método Opcional (O método opcional como o nome já diz, a implementação dele será opcional)
  public void CalculoPoupanca(double valor, double taxa) 
  {
    Console.WriteLine("Ganhos obtidos pela poupança R$" + (valor * taxa));
  }
}