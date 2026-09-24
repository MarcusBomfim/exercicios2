/*
|--------------------------------------------------------------------------
| EXERCÍCIO 02 (FÁCIL) - Condicionais
|--------------------------------------------------------------------------
|
| Conteúdo praticado: if / else if / else, operadores lógicos (&&, ||, !),
| operador ternário e a expressão `switch`.
|
| 1) static string Situacao(double media, int faltas)
|    Regras do boletim:
|      - faltas acima de 10       -> "Reprovado por faltas" (vale antes de tudo)
|      - média >= 7,0             -> "Aprovado"
|      - média entre 5,0 e 6,9    -> "Recuperação"
|      - média abaixo de 5,0      -> "Reprovado"
|
|    Situacao(8.5, 2)  -> "Aprovado"
|    Situacao(6.0, 0)  -> "Recuperação"
|    Situacao(9.0, 12) -> "Reprovado por faltas"
|
| 2) static int MaiorDeTres(int a, int b, int c)
|    Devolve o maior dos três, sem usar Math.Max: só com if.
|    MaiorDeTres(3, 9, 5) -> 9
|
| 3) static string ParOuImpar(int numero)
|    Devolve "par" ou "ímpar". Use o operador ternário (?:) e o resto (%).
|    ParOuImpar(4) -> "par"     ParOuImpar(-3) -> "ímpar"
|
| 4) static string DiaDaSemana(int numero)
|    1 -> "domingo", 2 -> "segunda-feira", ..., 7 -> "sábado".
|    Qualquer outro número -> "inválido". Use a expressão `switch`:
|
|        var nome = numero switch { 1 => "domingo", ... , _ => "inválido" };
|
| 5) No fim do arquivo, mostre um resultado de cada método com
|    Console.WriteLine.
|
| Rode com:  dotnet run --project 02_Condicionais
|
*/

Console.WriteLine("Exercício 02 (fácil) — ainda sem solução.");
