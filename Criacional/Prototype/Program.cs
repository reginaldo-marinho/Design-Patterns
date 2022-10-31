Pessoa pessoa = new Pessoa ();
pessoa.Nome = "Reginaldo";
pessoa.Sobrenome = "Marinho";
pessoa.Idade = 25;
pessoa.Endereco = new Endereco ("Rua Geraldo Gutierres",101);

Console.WriteLine($"Pessoa Nome: {pessoa.Nome}");
Console.WriteLine($"Pessoa Sobrenome: {pessoa.Sobrenome}");
Console.WriteLine($"Pessoa Idade: {pessoa.Idade}");

Pessoa clone =  pessoa.ShallowCopy();
Console.WriteLine($"Pessoa clone Nome: {clone.Nome}");
Console.WriteLine($"Pessoa clone Sobrenome: {clone.Sobrenome}");
Console.WriteLine($"Pessoa clone Idade: {clone.Idade}");
Console.WriteLine($"Pessoa clone Endereço Logradouro: {clone.Endereco.Logradouro}");
Console.WriteLine($"Pessoa clone Endereço Numero: {clone.Endereco.Numero}");
