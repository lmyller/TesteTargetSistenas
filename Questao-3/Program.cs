
using System.Text.Json;

FaturamentoDiario();

void FaturamentoDiario()
{
    List<Faturamento>? dados = JsonSerializer.Deserialize<List<Faturamento>>(File.ReadAllText("dados/dados.json"))?
        .Where(faturamento => faturamento.valor > 0)
        .ToList();

    if (dados == null)
    {
        Console.WriteLine("Erro ao ler o arquivo JSON.");
        return;
    }

    decimal media = dados.Average(faturamento => faturamento.valor);
    short count = 0;

    Console.WriteLine($"Menor valor de faturamento: {dados.Min(faturamento => faturamento.valor):C}\n");
    Console.WriteLine($"Maior valor de faturamento: {dados.Max(faturamento => faturamento.valor):C}\n");

    foreach (var item in dados)
    {
        if (item.valor > media)
        {
            count++;
        }
    }

    Console.WriteLine($"Número de dias com faturamento maior que a média: {count}");
}

public record Faturamento
{
    public int dia { get; set; }
    public decimal valor { get; set; }
}