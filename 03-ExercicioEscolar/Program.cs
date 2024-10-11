namespace _03_ExercicioEscolar;

class Program
{
  static void Main(string[] args)
  {
    // Instanciar objeto
    Aluno aluno01 = new Aluno();

    aluno01.nome = "Joãozinho";
    aluno01.nota01 = 8;
    aluno01.nota02 = 10;
    aluno01.Mensagem();

    Aluno aluno02 = new Aluno();
    aluno02.nome = "Pedrinho";
    aluno02.nota01 = 7;
    aluno02.nota02 = 4;
    aluno02.Mensagem();
  }
}
