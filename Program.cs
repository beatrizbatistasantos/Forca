using System.Data.Common;

Console.Clear();

string PalavraSecreta = " ";
char palpite = 'x';

Console.WriteLine("###Jogo da Forca###");

Console.WriteLine("Digite a palavra secreta desejada:");

 PalavraSecreta = Console.ReadLine()!;

Console.WriteLine("Digite a letra que você acha que tem:");
palpite = char.Parse(Console.ReadLine()!.ToLower());

//Console.ReadKey().KeyChar; 
//Também é possível utilizar comando acima ao invés do comando abaixo char.Parse....

Console.WriteLine($"A letra {palpite} {(PalavraSecreta.Contains(palpite) ? "existe" : "não existe")} na palavra {PalavraSecreta}");

Console.ReadKey(true);