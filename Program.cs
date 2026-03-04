
List<string> Compras = new List<string>();
string item = "";

Console.WriteLine("Lista de Compras Simples");

System.Console.WriteLine("Informe o item a ser adicionado ao carrinho: ");
item = Console.ReadLine();

while (item != "Sair") {
    System.Console.WriteLine("Proximo item: ");
    item = Console.ReadLine();
    if (item != "Sair")
    {
        Compras.Add(item);
    }
}
System.Console.WriteLine();
System.Console.WriteLine("- Esta é sua lista de compras -");
foreach(string thing in Compras)
{
    System.Console.WriteLine(thing);
}