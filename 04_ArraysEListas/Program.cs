/*
|--------------------------------------------------------------------------
| EXERCÍCIO 04 (FÁCIL) - Arrays e List<T>
|--------------------------------------------------------------------------
|
| Conteúdo praticado: arrays (int[]), List<int>, foreach, tuplas com nome
| e os primeiros métodos de LINQ (Sum, Max, Min, Where, Distinct, ToList).
|
| 1) static double Media(int[] numeros)
|    Média aritmética. Se o array estiver vazio, devolva 0.0.
|    Cuidado: a divisão de dois int em C# descarta a parte decimal.
|    Media(new[] { 2, 4, 7 }) -> 4.333...
|
| 2) static (int maior, int menor) MaiorEMenor(int[] numeros)
|    Devolve uma tupla com nome. Percorra o array com foreach — sem Max/Min.
|    MaiorEMenor(new[] { 3, 9, 1 }) -> (9, 1)
|    Com array vazio, lance ArgumentException com uma mensagem clara.
|
| 3) static List<int> ApenasPares(List<int> numeros)
|    Devolve só os pares, na ordem original.
|    Faça de duas formas: com foreach + if, e depois com LINQ (Where).
|    ApenasPares([1, 2, 3, 4]) -> [2, 4]
|
| 4) static List<string> RemoverDuplicados(List<string> itens)
|    Remove repetidos mantendo a ordem da primeira ocorrência.
|    RemoverDuplicados(["a", "b", "a", "c", "b"]) -> ["a", "b", "c"]
|    (Distinct() resolve em uma linha; faça também sem ele, com Contains.)
|
| 5) No fim do arquivo, mostre os resultados. Para imprimir uma lista numa
|    linha só, veja string.Join(", ", lista).
|
| Rode com:  dotnet run --project 04_ArraysEListas
|
*/

Console.WriteLine($"Media([2, 4, 7]) = {Media([2, 4, 7])}");
Console.WriteLine($"Media([])        = {Media([])}");

Console.WriteLine();
var extremos = MaiorEMenor([3, 9, 1]);
Console.WriteLine($"MaiorEMenor([3, 9, 1]) -> maior {extremos.maior}, menor {extremos.menor}");

try
{
    MaiorEMenor([]);
}
catch (ArgumentException erro)
{
    Console.WriteLine($"MaiorEMenor([]) recusou: {erro.Message}");
}

Console.WriteLine();
List<int> numeros = [1, 2, 3, 4, 5, 6];
Console.WriteLine($"ApenasPares      = {string.Join(", ", ApenasPares(numeros))}");
Console.WriteLine($"ApenasParesComLinq = {string.Join(", ", ApenasParesComLinq(numeros))}");

Console.WriteLine();
List<string> itens = ["a", "b", "a", "c", "b"];
Console.WriteLine($"RemoverDuplicados        = {string.Join(", ", RemoverDuplicados(itens))}");
Console.WriteLine($"RemoverDuplicadosComLinq = {string.Join(", ", RemoverDuplicadosComLinq(itens))}");

/// <summary>Média aritmética. Array vazio devolve 0.</summary>
static double Media(int[] numeros)
{
    // Sem este if seria divisão por zero — que em double devolve NaN
    // em silêncio, pior do que um erro.
    if (numeros.Length == 0)
    {
        return 0.0;
    }

    int soma = 0;

    foreach (int numero in numeros)
    {
        soma += numero;
    }

    /*
     * O (double) é a armadilha do exercício: int / int faz divisão inteira
     * e DESCARTA a parte decimal. Sem o cast, 13 / 3 daria 4, e o tipo de
     * retorno double não salvaria — a conta já teria sido feita errado.
     */
    return (double)soma / numeros.Length;
}

/// <summary>O maior e o menor, numa tupla com nome.</summary>
static (int maior, int menor) MaiorEMenor(int[] numeros)
{
    if (numeros.Length == 0)
    {
        // nameof gera a string "numeros" em tempo de compilação: se o
        // parâmetro for renomeado, a mensagem acompanha.
        throw new ArgumentException("A lista está vazia: não há maior nem menor.", nameof(numeros));
    }

    /*
     * Os dois começam no primeiro elemento, e não em 0 nem em int.MaxValue.
     * Se "menor" começasse em 0, uma lista só de positivos devolveria 0 —
     * um número que não está na lista.
     */
    int maior = numeros[0];
    int menor = numeros[0];

    foreach (int numero in numeros)
    {
        if (numero > maior)
        {
            maior = numero;
        }

        if (numero < menor)
        {
            menor = numero;
        }
    }

    return (maior, menor);
}

/// <summary>Só os pares, na ordem original — versão manual.</summary>
static List<int> ApenasPares(List<int> numeros)
{
    var pares = new List<int>();

    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
        {
            pares.Add(numero);
        }
    }

    return pares;
}

/*
 * A mesma coisa com LINQ. Where é o array_filter, e n => n % 2 == 0 é a
 * função anônima. O LINQ é preguiçoso: nada é percorrido até o ToList().
 */
static List<int> ApenasParesComLinq(List<int> numeros) => numeros.Where(n => n % 2 == 0).ToList();

/// <summary>Remove repetidos mantendo a ordem da primeira ocorrência.</summary>
static List<string> RemoverDuplicados(List<string> itens)
{
    var unicos = new List<string>();

    foreach (string item in itens)
    {
        /*
         * Contains percorre a lista inteira a cada item, então o custo
         * cresce com o quadrado do tamanho. Com 10 itens não importa;
         * com 100 mil, trava. O Distinct abaixo usa hash e não tem isso.
         */
        if (!unicos.Contains(item))
        {
            unicos.Add(item);
        }
    }

    return unicos;
}

static List<string> RemoverDuplicadosComLinq(List<string> itens) => itens.Distinct().ToList();
