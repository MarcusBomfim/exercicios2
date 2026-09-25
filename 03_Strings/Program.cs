/*
|--------------------------------------------------------------------------
| EXERCÍCIO 03 (FÁCIL) - Strings
|--------------------------------------------------------------------------
|
| Conteúdo praticado: métodos de string (Length, ToUpper, ToLower, Trim,
| Split, Replace, Contains), laço foreach sobre os caracteres e
| concatenação (ou StringBuilder).
|
| 1) static string Inverter(string texto)
|    Devolve o texto de trás para a frente. Sem usar bibliotecas prontas
|    de inversão: percorra os caracteres do fim para o começo.
|    Inverter("obra") -> "arbo"
|
| 2) static bool EhPalindromo(string texto)
|    Verdadeiro se o texto for igual ao seu inverso, ignorando maiúsculas,
|    minúsculas e espaços.
|    EhPalindromo("Ana")                   -> true
|    EhPalindromo("a base do teto desaba")  -> true
|    EhPalindromo("concreto")              -> false
|
| 3) static int ContarVogais(string texto)
|    Quantas vogais (a, e, i, o, u, sem acento) o texto tem, sem diferenciar
|    maiúsculas de minúsculas.
|    ContarVogais("Engenharia") -> 5
|
| 4) static string Iniciais(string nomeCompleto)
|    Devolve as iniciais em maiúsculas, separadas por ponto. Use Split e
|    ignore espaços duplicados (veja StringSplitOptions.RemoveEmptyEntries).
|    Iniciais("marcus bomfim")          -> "M.B."
|    Iniciais("  ana   clara  souza ")  -> "A.C.S."
|
| 5) No fim do arquivo, chame cada método e mostre o resultado.
|
| Rode com:  dotnet run --project 03_Strings
|
*/

// StringBuilder mora aqui; não entra nos usings implícitos do projeto.
using System.Text;

Console.WriteLine($"Inverter(\"obra\") = {Inverter("obra")}");

Console.WriteLine();
Console.WriteLine($"\"Ana\" é palíndromo?                   {EhPalindromo("Ana")}");
Console.WriteLine($"\"a base do teto desaba\" é palíndromo? {EhPalindromo("a base do teto desaba")}");
Console.WriteLine($"\"concreto\" é palíndromo?              {EhPalindromo("concreto")}");

Console.WriteLine();
Console.WriteLine($"ContarVogais(\"Engenharia\") = {ContarVogais("Engenharia")}");

Console.WriteLine();
Console.WriteLine($"Iniciais(\"marcus bomfim\")        = {Iniciais("marcus bomfim")}");
Console.WriteLine($"Iniciais(\"  ana   clara  souza \") = {Iniciais("  ana   clara  souza ")}");

/// <summary>O texto de trás para a frente.</summary>
static string Inverter(string texto)
{
    /*
     * String em C# é imutável: "resultado += c" cria uma string nova a cada
     * volta e joga a anterior fora. O StringBuilder mantém um buffer que
     * cresce e só vira string no ToString() do fim.
     */
    var invertido = new StringBuilder();

    for (int i = texto.Length - 1; i >= 0; i--)
    {
        invertido.Append(texto[i]);
    }

    return invertido.ToString();
}

/// <summary>Palíndromo, ignorando maiúsculas, minúsculas e espaços.</summary>
static bool EhPalindromo(string texto)
{
    string limpo = texto.ToLower().Replace(" ", "");

    // Em C# o == entre strings compara o conteúdo, não a referência.
    // Não trata acentos: "Aciça" não seria reconhecido.
    return limpo == Inverter(limpo);
}

/// <summary>Quantas vogais sem acento o texto tem.</summary>
static int ContarVogais(string texto)
{
    int total = 0;

    // foreach sobre uma string percorre os caracteres, um a um.
    foreach (char c in texto.ToLower())
    {
        // A string curta faz papel de conjunto e evita cinco comparações com ||.
        if ("aeiou".Contains(c))
        {
            total++;
        }
    }

    return total;
}

/// <summary>Iniciais em maiúsculas, separadas por ponto: "M.B.".</summary>
static string Iniciais(string nomeCompleto)
{
    /*
     * RemoveEmptyEntries é o ponto do exercício: sem ele, "  ana   clara  "
     * viraria ["", "", "ana", "", "", "clara", "", ""] e parte[0] estouraria
     * nas entradas vazias.
     */
    string[] partes = nomeCompleto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var iniciais = new StringBuilder();

    foreach (string parte in partes)
    {
        // parte[0] pega o primeiro caractere, como se a string fosse array.
        iniciais.Append(char.ToUpper(parte[0])).Append('.');
    }

    return iniciais.ToString();
}
