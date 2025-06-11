# Projeto de Treinamento em C#

## Descrição

Este é um projeto simples em C# criado para fins de treinamento e aprendizado. O projeto demonstra conceitos básicos da linguagem, como a criação de classes, objetos, propriedades e métodos.

O programa principal (`Program.cs`) cria uma instância de uma classe `Pessoa`, define seus atributos (Nome e Idade) e chama um método para apresentar as informações da pessoa no console.

## Como Executar

1.  **Clone o repositório:**
    ```bash
    git clone <URL_DO_REPOSITORIO>
    cd <NOME_DO_DIRETORIO_DO_REPOSITORIO>
    ```
2.  **Compile o projeto:**
    Navegue até o diretório raiz do projeto (onde o arquivo `.csproj` está localizado) e execute o seguinte comando:
    ```bash
    dotnet build
    ```
3.  **Execute o projeto:**
    Após a compilação bem-sucedida, execute o programa com o seguinte comando:
    ```bash
    dotnet run
    ```
    Isso executará o método `Main` em `Program.cs` e você verá a saída no console.

## Estrutura do Projeto

*   `Program.cs`: Contém o ponto de entrada do programa (método `Main`). Ele instancia e utiliza a classe `Pessoa`.
*   `Models/`: Esta pasta contém as classes de modelo do projeto.
    *   `Pessoa.cs`: Define a classe `Pessoa` com propriedades para nome e idade, e um método para apresentar a pessoa.
*   `*.csproj`: Arquivo de projeto do C# que define as configurações de compilação e dependências.
*   `*.sln`: Arquivo de solução do Visual Studio, usado para agrupar um ou mais projetos.
