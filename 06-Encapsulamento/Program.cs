namespace _06_Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
      Aluno aluno = new Aluno();

      aluno.Mensagem(); // Acesso ao único método público da classe
    }
}
