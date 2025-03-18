# Classificacao De Triangulos

## Projeto
Um simples programa desenvolvido para classificar um triângulo, com base nos comprimentos dos três lados fornecidos pelo usuário.
Sendo eles:
- **Equilátero:** Todos os lados contém o mesmo valor.
- **Isósceles:** Dois lados possuem valores iguais, enquanto o terceiro é diferente.
- **Escaleno:** Todos os lados contém valores diferentes.

## Como Funciona
1. O usuário insere os valores dos três lados, em sua ordem (X, Y e Z).
2. O programa verifica os valores, garantindo que é um triângulo válido.
3. Os valores resultando em um triângulo válido, ele determina qual o tipo do triângulo.
4. Caso os valores resultem em um triângulo inválido, ele irá informar ao usuário.

### Exemplo:
```sh
/-----------------------------------------\
        Classificador de Triângulos
/-----------------------------------------\

Valores Informados:
Lado X: 2
Lado Y: 3
Lado Z: 4

/-----------------------------------------\
O triângulo é Escaleno.
```

## Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como utilizar
1. **Clone o Repositório**
```
git clone https://github.com/gsvsantos/ClassificacaoDeTriangulos.git
```
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz da Calculadora.
3. Utilize o comando abaixo para restaurar as dependências do projeto.
```
dotnet restore
```
4. Compile e execute o arquivo *.exe* da calculadora:
```
dotnet build --configuration Release
```
```
ClassificacaoDeTriangulos\ClassificacaoDeTriangulos.ConsoleApp\bin\Release\net8.0\ClassificacaoDeTriangulos.ConsoleApp.exe
```
### Opcional
- Executar o projeto compilando em tempo real
```
dotnet run --project ClassificacaoDeTriangulos.ConsoleApp
```

# Sobre o Projeto
Este projeto foi desenvolvido como parte de uma atividade da [Academia do Programador](https://www.instagram.com/academiadoprogramador/).
