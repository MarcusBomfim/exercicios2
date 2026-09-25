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

Console.WriteLine("--- Situação no boletim ---");
Console.WriteLine($"média 8,5 com  2 faltas -> {Situacao(8.5, 2)}");
Console.WriteLine($"média 6,0 com  0 faltas -> {Situacao(6.0, 0)}");
Console.WriteLine($"média 4,9 com  0 faltas -> {Situacao(4.9, 0)}");
Console.WriteLine($"média 9,0 com 12 faltas -> {Situacao(9.0, 12)}");

Console.WriteLine();
Console.WriteLine($"MaiorDeTres(3, 9, 5) = {MaiorDeTres(3, 9, 5)}");
Console.WriteLine($"ParOuImpar(4)  = {ParOuImpar(4)}");
Console.WriteLine($"ParOuImpar(-3) = {ParOuImpar(-3)}");

Console.WriteLine();
Console.WriteLine($"DiaDaSemana(1) = {DiaDaSemana(1)}");
Console.WriteLine($"DiaDaSemana(7) = {DiaDaSemana(7)}");
Console.WriteLine($"DiaDaSemana(9) = {DiaDaSemana(9)}");

/// <summary>Situação do aluno. As faltas são conferidas antes da média.</summary>
static string Situacao(double media, int faltas)
{
    // A ordem é a regra: reprovação por faltas vale mesmo com média 9.
    if (faltas > 10)
    {
        return "Reprovado por faltas";
    }

    if (media >= 7.0)
    {
        return "Aprovado";
    }

    // Não precisa de "&& media < 7.0": se fosse 7 ou mais, o if acima já
    // teria retornado. Condição redundante é lugar onde bug se esconde.
    if (media >= 5.0)
    {
        return "Recuperação";
    }

    return "Reprovado";
}

/// <summary>O maior de três números, só com if.</summary>
static int MaiorDeTres(int a, int b, int c)
{
    // Assume que o primeiro é o maior e vai corrigindo. É o mesmo padrão
    // que serve para uma lista de mil números — só mudaria o laço.
    int maior = a;

    if (b > maior)
    {
        maior = b;
    }

    if (c > maior)
    {
        maior = c;
    }

    return maior;
}

/*
 * Em C#, -3 % 2 dá -1, e não 1. Por isso a comparação é "== 0": testar
 * "== 1" faria o -3 cair no lado errado e virar "par".
 */
static string ParOuImpar(int numero) => numero % 2 == 0 ? "par" : "ímpar";

/*
 * Expressão switch: devolve um valor, então cabe direto num return. O "_"
 * é o caso padrão, e sem ele o compilador avisa que falta caso.
 */
static string DiaDaSemana(int numero) => numero switch
{
    1 => "domingo",
    2 => "segunda-feira",
    3 => "terça-feira",
    4 => "quarta-feira",
    5 => "quinta-feira",
    6 => "sexta-feira",
    7 => "sábado",
    _ => "inválido",
};
