/*
  Interface
  Utilizada para criar exclusivamente métodos obrigatórios
  Uma classe pode implementar várias interfaces
  Os métodos da interface não contem cálculos, condicionais, laços ou demais ações, a regra de negócio fica por conta da classe que vai implementá-la
  No C# por padrão um método criado na interface é abstrato e público, com isso não precisa ser informado a visibilidade na hora de criá-lo
  Nas boas práticas do C#, o nome de toda interface tem o I na frente do nome
*/

// Interface
interface IPadrao
{
  // Métodos obrigatórios
  void Somar(int n1, int n2);

  void Subtrair(int n1, int n2);
}