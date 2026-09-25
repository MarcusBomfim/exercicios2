/*
|--------------------------------------------------------------------------
| EXERCÍCIO 01 (FÁCIL) - Variáveis, operadores e laço for
|--------------------------------------------------------------------------
|
| Conteúdo praticado: tipos (int, double, string), interpolação de string
| ($"..."), laço `for`, Math.Round e Console.WriteLine.
|
| 1) static string[] Tabuada(int numero)
|    Devolve um array com as 10 linhas da tabuada do número, no formato
|    "3 x 1 = 3". Use um laço `for` de 1 até 10.
|
|    Tabuada(3)[0]  ->  "3 x 1 = 3"
|    Tabuada(3)[9]  ->  "3 x 10 = 30"
|
| 2) static int SomaAte(int limite)
|    Soma todos os inteiros de 1 até `limite` (inclusive).
|    SomaAte(5) -> 15   (1+2+3+4+5)
|    SomaAte(0) -> 0
|
| 3) static double PrecoComDesconto(double preco, double percentual)
|    Aplica um desconto percentual e devolve o novo preço arredondado
|    para 2 casas decimais (veja Math.Round).
|    PrecoComDesconto(100.0, 10.0) -> 90.0
|    PrecoComDesconto(59.9, 15.0)  -> 50.92
|
| 4) No fim do arquivo, chame os três métodos e mostre os resultados com
|    Console.WriteLine. Imprima a tabuada do 7 uma linha por vez.
|
| Dica: com "top-level statements" (este arquivo não tem Main), os métodos
| podem ser declarados como funções locais, abaixo das chamadas.
|
| Rode com:  dotnet run --project 01_VariaveisETabuada
|
*/

Console.WriteLine("--- Tabuada do 7 ---");

foreach (string linha in Tabuada(7))
{
    Console.WriteLine(linha);
}

Console.WriteLine();
Console.WriteLine($"SomaAte(5)   = {SomaAte(5)}");
Console.WriteLine($"SomaAte(0)   = {SomaAte(0)}");
Console.WriteLine($"SomaAte(100) = {SomaAte(100)}");

Console.WriteLine();
Console.WriteLine($"PrecoComDesconto(100,00, 10%) = {PrecoComDesconto(100.0, 10.0)}");
Console.WriteLine($"PrecoComDesconto(59,90,  15%) = {PrecoComDesconto(59.9, 15.0)}");

/// <summary>As 10 linhas da tabuada, no formato "3 x 1 = 3".</summary>
static string[] Tabuada(int numero)
{
    // O tamanho é fixo: toda tabuada tem 10 linhas. Se fosse variável,
    // o certo seria List<string> com Add().
    var linhas = new string[10];

    for (int i = 1; i <= 10; i++)
    {
        // O laço vai de 1 a 10 porque é assim que se lê uma tabuada,
        // mas o array começa no índice 0 — daí o i - 1.
        linhas[i - 1] = $"{numero} x {i} = {numero * i}";
    }

    return linhas;
}

/// <summary>Soma de 1 até o limite. Limite zero ou negativo devolve 0.</summary>
static int SomaAte(int limite)
{
    int total = 0;

    // Com limite 0 a condição já é falsa na primeira volta e o corpo
    // nunca roda: o retorno é 0 sem precisar de if.
    for (int i = 1; i <= limite; i++)
    {
        total += i;
    }

    return total;
}

/// <summary>Preço com desconto percentual, arredondado a 2 casas.</summary>
static double PrecoComDesconto(double preco, double percentual)
{
    return Math.Round(preco - (preco * percentual / 100), 2);
}
