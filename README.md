# SELECT Verificador Léxico (C#)

Este é um projeto simples em C# que verifica se uma palavra digitada pelo usuário corresponde exatamente à palavra `select`, aceitando tanto letras minúsculas quanto maiúsculas, com análise **caractere por caractere** baseada em dicionários de mapeamento.

## 🚀 Como funciona

O programa possui dois dicionários:

- `mapaMin`: contém o mapeamento da palavra "select" em letras minúsculas.
- `mapaMax`: contém o mapeamento da palavra "SELECT" em letras maiúsculas.

A entrada do usuário é analisada caractere por caractere. Cada caractere é comparado com o valor esperado na posição correspondente nos dicionários.

Se todos os caracteres corresponderem (em maiúsculo ou minúsculo), a palavra é considerada válida.



