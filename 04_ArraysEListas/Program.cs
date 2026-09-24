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

Console.WriteLine("Exercício 04 (fácil) — ainda sem solução.");
