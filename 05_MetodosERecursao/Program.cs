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

Console.WriteLine(Saudacao("Marcus"));
Console.WriteLine(Saudacao("Marcus", "Bom dia"));
Console.WriteLine(Saudacao(tratamento: "Boa noite", nome: "Ana"));

Console.WriteLine();
Console.WriteLine($"Fatorial(5)  = {Fatorial(5)}");
Console.WriteLine($"Fatorial(20) = {Fatorial(20)}");

try
{
    Fatorial(-1);
}
catch (ArgumentOutOfRangeException erro)
{
    Console.WriteLine($"Fatorial(-1) recusou: {erro.ParamName} não pode ser negativo");
}

Console.WriteLine();
var fibonacci = new List<string>();

for (int posicao = 0; posicao <= 10; posicao++)
{
    fibonacci.Add(Fibonacci(posicao).ToString());
}

Console.WriteLine($"Fibonacci de 0 a 10: {string.Join(" ", fibonacci)}");

Console.WriteLine();
Console.WriteLine($"EhPrimo(1)  = {EhPrimo(1)}");
Console.WriteLine($"EhPrimo(2)  = {EhPrimo(2)}");
Console.WriteLine($"EhPrimo(9)  = {EhPrimo(9)}");
Console.WriteLine($"EhPrimo(97) = {EhPrimo(97)}");

Console.WriteLine();
ContagemRegressiva(5);

/*
 * Parâmetro com valor padrão vem depois dos obrigatórios. Na chamada dá
 * para nomear os parâmetros e inverter a ordem — útil quando o método tem
 * vários argumentos do mesmo tipo.
 */
static string Saudacao(string nome, string tratamento = "Olá") => $"{tratamento}, {nome}!";

/// <summary>Fatorial recursivo. Devolve long porque 20! não cabe em int.</summary>
static long Fatorial(int n)
{
    if (n < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(n), "Não existe fatorial de número negativo.");
    }

    // Caso base: sem ele a função se chamaria para sempre até estourar a pilha.
    if (n == 0)
    {
        return 1;
    }

    /*
     * 20! é 2.432.902.008.176.640.000, e o int vai só até ~2,1 bilhões.
     * Pior: por padrão o estouro não gera erro em C# — o número dá a volta
     * e devolve resultado errado em silêncio. De 21 em diante nem o long
     * basta; aí seria System.Numerics.BigInteger.
     */
    return n * Fatorial(n - 1);
}

/// <summary>Fibonacci recursivo. Dois casos base, porque olha duas posições atrás.</summary>
static int Fibonacci(int posicao)
{
    if (posicao == 0)
    {
        return 0;
    }

    if (posicao == 1)
    {
        return 1;
    }

    /*
     * Esta versão é elegante e ineficiente: cada chamada gera duas, e o
     * mesmo valor é recalculado muitas vezes. Fibonacci(10) faz 177
     * chamadas; Fibonacci(50) faria mais de 40 bilhões. A solução seria
     * guardar os resultados já calculados, ou usar um laço.
     */
    return Fibonacci(posicao - 1) + Fibonacci(posicao - 2);
}

/// <summary>Primo: divisível só por 1 e por ele mesmo.</summary>
static bool EhPrimo(int numero)
{
    // Cobre 0, 1 e os negativos, que não são primos por definição.
    if (numero < 2)
    {
        return false;
    }

    /*
     * Testar até a raiz quadrada basta porque os divisores vêm em pares:
     * em 36 são 2×18, 3×12, 4×9, 6×6 — passou de 6, só se repetem
     * invertidos. Para 1.000.000 são 1.000 testes em vez de 1.000.000.
     */
    for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
    {
        if (numero % divisor == 0)
        {
            return false;
        }
    }

    return true;
}

/// <summary>Conta de "de" até 1 e imprime "Fim!". Recursiva, sem laço.</summary>
static void ContagemRegressiva(int de)
{
    if (de <= 0)
    {
        Console.WriteLine("Fim!");

        // Sem este return a execução seguiria e chamaria a função de novo.
        return;
    }

    Console.WriteLine(de);
    ContagemRegressiva(de - 1);
}
