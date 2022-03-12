string fraseOriginal;

Console.Write("Por favor, digite algo que tenha a letra R: ");
fraseOriginal = Console.ReadLine()!; // Armazena o conteúdo digitado pelon usuário na variável

Console.WriteLine(fraseOriginal.Replace("r", "l").Replace("R", "L")); // Exibe novamente a frase, substituindo r e R com l e L