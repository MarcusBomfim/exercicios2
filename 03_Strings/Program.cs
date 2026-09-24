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

Console.WriteLine("Exercício 03 (fácil) — ainda sem solução.");
