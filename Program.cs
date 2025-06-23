using bootcamp.Models;

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(50, 20);
calc.Multiplicar(5, 5);
calc.Dividir(100, 4);



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Rafael Queiroz";
// pessoa1.Idade = 39;
// pessoa1.Apresentar();

// testando VARIAVEIS

// string apresentacao = "Olá, meu nome é Rafael Queiroz e tenho 39 anos.";

// int quantidade = 10;
// quantidade = 20;

// double altura = 1.82;

// decimal peso = 95.5M;

// bool condicao = true;

// DateTime data = DateTime.Now;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Quantidade: {quantidade}");
// Console.WriteLine("Altura: " + altura.ToString("0.0"));
// Console.WriteLine("Peso: " + peso + "kg");
// Console.WriteLine($"Condicao: {condicao}");
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// DateTime dataNascimento = new DateTime(1984, 12, 11);
// Console.WriteLine($"Data de Nascimento: {dataNascimento.ToShortDateString()}");

// string dia = "15";
// int b = 0;
// Console.WriteLine(b);
// int.TryParse(dia, out b);

// Console.WriteLine("Conversão realizada com sucesso");

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 5;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine("Venda não realizada. Estoque insuficiente.");
// }

// bool presenca = true;
// double media = 8.0;

// if (presenca && media >= 7.0)
// {
//     Console.WriteLine("Aprovado!");
// }
// else if (presenca && media >= 5.0)
// {
//     Console.WriteLine("Recuperação!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }