# Exercícios de C#

5 exercícios fáceis de C# para praticar o básico da linguagem: variáveis,
condicionais, strings, coleções e métodos.

Cada exercício é um projeto de console. O `Program.cs` contém apenas o
**enunciado**, em um comentário no topo. Você escreve a solução no próprio
arquivo, abaixo do comentário — o arquivo usa *top-level statements*, então
não precisa de classe nem de `Main`.

## Requisitos

**.NET SDK 8 ou superior** (os projetos foram criados com o .NET 10).

```bash
dotnet --version
```

Se ainda não tiver: baixe em [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
No VS Code, instale a extensão **C# Dev Kit**.

## Como rodar

Cada exercício roda separado, pela pasta dele:

```bash
dotnet run --project 01_VariaveisETabuada
```

Para abrir tudo de uma vez no Visual Studio ou no VS Code, use o
`Exercicios2.slnx`.

## Lista dos exercícios

| # | Pasta | Assunto |
|---|-------|---------|
| 01 | `01_VariaveisETabuada` | tipos, interpolação de string, laço `for`, `Math.Round` |
| 02 | `02_Condicionais` | `if/else if`, operadores lógicos, ternário, expressão `switch` |
| 03 | `03_Strings` | métodos de string, `Split`, `foreach` em caracteres, palíndromo |
| 04 | `04_ArraysEListas` | `int[]`, `List<T>`, tuplas com nome, primeiros métodos de LINQ |
| 05 | `05_MetodosERecursao` | parâmetro padrão e nomeado, recursão, `long`, primos |

## Estrutura

```text
.
├── Exercicios2.slnx
├── 01_VariaveisETabuada/
│   ├── 01_VariaveisETabuada.csproj
│   └── Program.cs
├── 02_Condicionais/
├── 03_Strings/
├── 04_ArraysEListas/
└── 05_MetodosERecursao/
```

As pastas `bin/` e `obj/` são geradas pelo `dotnet` e ficam fora do git.
