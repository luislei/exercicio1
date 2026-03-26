namespace Exercicio1;

// <summary>
    /// 📋 SUMÁRIO DOS EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS
    /// =====================================================
    ///
    /// Exercício 1: Declaração de variáveis básicas
    /// - Aprender a declarar variáveis com tipos diferentes
    /// - Usar string (texto), int (números inteiros) e bool (verdadeiro/falso)
    /// - Utilizar o método GetType() para descobrir o tipo da variável
    ///
    /// Exercício 2: Reatribuição de valores
    /// - Entender que variáveis podem mudar de valor
    /// - Declarar uma variável e depois atribuir um novo valor
    ///
    /// Exercício 3: Flexibilidade do tipo object
    /// - Conhecer o tipo object que pode guardar qualquer tipo de dado
    /// - Ver como o tipo pode mudar durante a execução
    ///
    /// Demonstração adicional:
    /// - Conhecer outros tipos: double (decimais), char (um caractere), decimal (precisão monetária)
    /// </summary>
    public class ExerciciosVariaveisETiposDeDados
    {

        
        public void Executar()
        {
            Console.WriteLine("\n📋 1. EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS");
            Console.WriteLine("============================================\n");
 
            // ===================================================
            // EXERCÍCIO 1: Declaração de variáveis básicas
            // ===================================================
            // Objetivo: Aprender a criar variáveis com os tipos mais comuns
            // string → guarda texto
            // int → guarda números inteiros
            // bool → guarda verdadeiro (true) ou falso (false)
            Console.WriteLine("📝 Exercício 1: Variáveis básicas");
 
            int ano = 1968;
            string nome =  "Luis";
            bool trabalha = true;


 
            Console.WriteLine($"int -> ano : {ano} (numeros inteiros)");
            Console.WriteLine($"nome : {nome}");
            Console.WriteLine($"trabalha ? {trabalha}");

            Console.WriteLine();


            // ===================================================
            // EXERCÍCIO 2: Reatribuição de valores
            // ===================================================
            // Objetivo: Mostrar que variáveis podem receber novos valores
            // A mesma variável pode guardar um valor diferente mais tarde
            Console.WriteLine("📝 Exercício 2: Reatribuição de valores");
 
            ano = 2026;
            nome = "Lei";
            trabalha = false;

            Console.WriteLine($"novo ano : {ano} (numeros inteiros)");
            Console.WriteLine($"novo nome : {nome}");
            Console.WriteLine($"trabalha ? {trabalha}"); 

            Console.WriteLine();


            // ===================================================
            // EXERCÍCIO 3: Tipo object (equivalente ao any)

            // ===================================================
            // Objetivo: Entender que o tipo object pode guardar qualquer coisa
            // É como uma caixa que pode conter diferentes tipos de objetos
            Console.WriteLine("📝 Exercício 3: Flexibilidade do tipo object");
 
 


            // ===================================================
            // DEMONSTRAÇÃO ADICIONAL DE TIPOS
            // ===================================================
            // Objetivo: Conhecer mais tipos disponíveis em C#
            // double → números decimais (com vírgula)
            // char → um único caractere (letra)
            // decimal → números decimais com alta precisão (usado para dinheiro)
            Console.WriteLine("📝 Demonstração adicional de tipos");
 

            double Pi = 3.141516;
            char Letra = 'Z';
            decimal Troco = 0.50m;

            Console.WriteLine ();

            Console.WriteLine ($"Pi {Pi}");
            Console.WriteLine ($"Letra {Letra}");
            Console.WriteLine ($"Troco: {Troco}");


                  
        }
    }
