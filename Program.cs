
List<string> Compras = new List<string>();
string item = "";

Console.WriteLine("--- Lista de Compras Simples ---");
Console.WriteLine("(Digite 'Sair' para finalizar)\n");

while (true) {
    System.Console.WriteLine("Informe o item ou 'Sair'");
    item = Console.ReadLine();

    if (item.Equals("Sair", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    if (!string.IsNullOrWhiteSpace(item))
    {
        Compras.Add(item);
    }
}

Console.WriteLine($"\n--- Sua lista contém {Compras.Count} itens ---");
foreach(string thing in Compras)
{
    System.Console.WriteLine($"- {thing}");
}