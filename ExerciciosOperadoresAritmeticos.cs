namespace Exercicio1;

 


  /// <summary>
  /// 🧮 SUMÁRIO DOS EXERCÍCIOS DE OPERADORES ARITMÉTICOS
  /// =================================================
  ///
  /// Exercício 1: Soma e subtração
  /// - Aprender a usar os operadores + (soma) e - (subtração)
  /// - Guardar o resultado em variáveis
  /// - Exibir os resultados no console
  ///
  /// Exercício 2: Cálculo de área do retângulo
  /// - Aplicar a multiplicação (*) em um problema real
  /// - Calcular área = largura × altura
  /// - Trabalhar com números decimais (double)
  ///
  /// Exercício 3: Operador módulo (resto da divisão)
  /// - Entender o operador % que retorna o resto da divisão
  /// - Exemplo prático: 20 ÷ 6 = 3, resto 2
  /// - Útil para verificar se um número é par ou ímpar
  ///
  /// Demonstração adicional:
  /// - Multiplicação e divisão com conversão de tipos (cast)
  /// - Operador de incremento (++) que aumenta o valor em 1
  /// - Formatação de números decimais com :F2 (2 casas decimais)
  /// </summary>
  ///
 
 
 
  public class exerciciosOperadoresAritmeticos
  {
    public void Executar()
    {
      // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
      Console.WriteLine("\n🧮 3. EXERCÍCIOS DE OPERADORES ARITMÉTICOS");
      Console.WriteLine("=========================================\n");
 
      // ===================================================
      // EXERCÍCIO 1: Soma e subtração
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar duas variáveis numéricas
      // 1A. Crie outras duas variáveis chamada soma e subtração que receberão as 2 varias anteriores Ex: int soma = numero1 + numero2;
      // 2. Fazer uma soma usando +
      // 3. Fazer uma subtração usando -
      // 4. Mostrar os resultados no console
      //
      // 💡 Regra:
      // + → soma valores
      // - → subtrai valores
 
      Console.WriteLine("📝 Exercício 1: Soma e subtração");
 
        int numero1 = 10;
        int numero2 = 5;
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;

        Console.WriteLine($" numero 1 = {numero1}");       
        Console.WriteLine($" numero 2) = {numero2}");       
        Console.WriteLine($" soma (1+2) = {numero1 + numero2}");       
        Console.WriteLine($" soma (1+2) = {soma}");       
        Console.WriteLine($" subtração (1-2) = {numero1 - numero2}");       
        Console.WriteLine($" subtração (1-2) = {subtracao}");       

        Console.WriteLine();



      /**SAIDA na Tela  ou Resultado esperado
     � Exercício 1: Soma e subtração
     8 + 5 = 13
     8 - 5 = 3
     */
 
      // ===================================================
      // EXERCÍCIO 2: Cálculo de área
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar duas variáveis double (largura e altura) Ex: double largura = 5.0;
      // 2. Multiplicar os valores
      // 3. Mostrar o resultado
      //
      // 💡 Regra:
      // Área do retângulo = largura × altura
      // Usamos double para valores com casas decimais
 
      Console.WriteLine("📝 Exercício 2: Cálculo de área do retângulo");
 
      /**SAIDA na Tela  ou Resultado esperado
      � Exercício 2: Cálculo de área do retângulo
      Área do retângulo: 5 × 3 = 15
      */
      Console.WriteLine("📝 Exercício 2B: Repita o exercicio 2");
      //Mas agora ao invés de ter variáveis com dados fixo, pesquise qual é o metodo de ENTRADA do C# e abasteça(Atribua o valor com este metodo)
      //Com isto poderá calcular retângulos diferentes.
      //  passe a usar Variáveis com valores Dinamicos ao ínves de Staticos, usando este metodo de ENTRADA.
 
 
 
      // ===================================================
      // EXERCÍCIO 3: Operador módulo (%)
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar 3 variaveis números inteiros, sendo que uma delas recebe o resultado do RESTO Ex:  int resto = dividendo % divisor;
      // 2. Usar o operador % para obter o resto
      // 3. Mostrar o resultado
      //
      // 💡 Regra:
      // % retorna o RESTO da divisão
      // passe a usar Variáveis com valores Dinamicos ao ínves de Staticos.
 
      Console.WriteLine("📝 Exercício 3: Operador módulo (%)");
 
      /*SAIDA na Tela  ou Resultado esperado supondo que usou os valores 6 e 20
     � Exercício 3: Operador módulo (resto da divisão)
     Resto da divisão de 20 por 6 = 2
      **/
 
 
 
 
      // ===================================================
      // EXERCÍCIO 4: Multiplicação e divisão
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar Vaariáveis int e double . Ex int multiplicacao, double divisao, num1 e num2
      // PESQUISE o que é CASTING e faça o casting para obter um resultado decimal na divisão. Ex: double divisao = (double)num1 / num2;  ou  double divisao = Convert.ToDouble(num1) / num2;
 
      // 2. Fazer uma multiplicação (*)
      // 3. Fazer uma divisão (/)
      // 4. Mostrar os resultados
      //
      // 💡 Regra:
      // * → multiplicação
      // / → divisão
      //Passe a usar Variáveis com valores Dinamicos ao ínves de Staticos, usando este metodo de ENTRADA.
      Console.WriteLine("📝 Exercício 4: Multiplicação e divisão");
 
 
      /**SAIDA na Tela  ou Resultado esperado
      � Exercício 4: Multiplicação e divisão
      Multiplicação: 8 × 5 = 40
      Divisão: 8 ÷ 5 = 1.60*/
 
 
 
 
 
 
 
 
 
      // ===================================================
      // EXERCÍCIO 5: Incremento
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar uma variável que receba o numero 1
      // 2. Use o operador ++
      // 3. Mostrar o valor antes e depois
      //
      // 💡 Regra:
      // ++ aumenta o valor em 1
      //Passe a usar Variáveis com valores Dinamicos ao ínves de Staticos, usando este metodo de ENTRADA.
 
      Console.WriteLine("📝 Exercício 5: Incremento");
 
 
    /**SAIDA na Tela  ou Resultado esperado
     � Demonstração adicional de operadores
     8 × 5 = 40
     8 ÷ 5 = 1.60
     Incremento de 8 virou : 9
    */
 
      // ===================================================
      // RESUMO FINAL
      // ===================================================
      // 👉 Objetivo:
      // Relembrar os principais operadores
 
      Console.WriteLine("📌 Resumo dos operadores:");
      Console.WriteLine("+  → soma");
      Console.WriteLine("-  → subtração");
      Console.WriteLine("*  → multiplicação");
      Console.WriteLine("/  → divisão");
      Console.WriteLine("%  → resto da divisão");
      Console.WriteLine("++ → incremento");
 
      Console.WriteLine();
    }
 
 
  }