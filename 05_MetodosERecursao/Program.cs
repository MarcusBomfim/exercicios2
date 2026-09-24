/*
|--------------------------------------------------------------------------
| EXERCÍCIO 05 (FÁCIL) - Métodos e recursão
|--------------------------------------------------------------------------
|
| Conteúdo praticado: métodos com retorno, parâmetro com valor padrão,
| parâmetro nomeado na chamada, recursão e o tipo long.
|
| 1) static string Saudacao(string nome, string tratamento = "Olá")
|    Saudacao("Marcus")             -> "Olá, Marcus!"
|    Saudacao("Marcus", "Bom dia")  -> "Bom dia, Marcus!"
|    Chame também com parâmetro nomeado:
|    Saudacao(tratamento: "Boa noite", nome: "Ana")
|
| 2) static long Fatorial(int n)
|    Recursivo: Fatorial(0) = 1 e Fatorial(n) = n * Fatorial(n - 1).
|    Para n negativo, lance ArgumentOutOfRangeException.
|    Fatorial(5) -> 120
|    Fatorial(20) -> 2432902008176640000 (por isso long, e não int)
|
| 3) static int Fibonacci(int posicao)
|    Recursivo: Fibonacci(0) = 0, Fibonacci(1) = 1,
|    Fibonacci(n) = Fibonacci(n - 1) + Fibonacci(n - 2).
|    Fibonacci(10) -> 55
|
| 4) static bool EhPrimo(int numero)
|    Verdadeiro se o número só for divisível por 1 e por ele mesmo.
|    Números menores que 2 não são primos. Basta testar divisores até a
|    raiz quadrada (Math.Sqrt).
|    EhPrimo(2) -> true    EhPrimo(9) -> false    EhPrimo(97) -> true
|
| 5) static void ContagemRegressiva(int de)
|    Imprime de `de` até 1, um número por linha, e por fim "Fim!".
|    Faça com recursão, sem laço.
|
| 6) No fim do arquivo, chame cada método. Para o Fibonacci, imprima as
|    posições de 0 a 10 numa linha só, separadas por espaço.
|
| Rode com:  dotnet run --project 05_MetodosERecursao
|
*/

Console.WriteLine("Exercício 05 (fácil) — ainda sem solução.");
