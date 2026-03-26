namespace Exercicio1;
public class Program

{
static void Main(string[] args)
{
    Console.WriteLine("Exercicio 1 \n");
    ExerciciosVariaveisETiposDeDados exerciciosVariaveisETiposDeDados = new ExerciciosVariaveisETiposDeDados();
    
    exerciciosVariaveisETiposDeDados.Executar();
    
    AlunoOperadoresLogicos alunoOperadoresLogicos = new AlunoOperadoresLogicos();

    alunoOperadoresLogicos.Executar();

    exerciciosOperadoresAritmeticos exerciciosOperadoresAritmeticos = new exerciciosOperadoresAritmeticos();

    exerciciosOperadoresAritmeticos.Executar();

}

}   // fim do public class 

// Fim do namespace