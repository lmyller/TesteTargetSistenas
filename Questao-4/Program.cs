FaturamentoMensal();

void FaturamentoMensal()
{
    decimal SP = 67836.43m,
            RJ = 36678.66m,
            MG = 29229.88m,
            ES = 27165.48m,
            OUTROS = 19849.53m;

    decimal total = SP + MG + RJ + ES + OUTROS;

    Console.WriteLine($"Lucro SP: {SP / total:p2}");
    Console.WriteLine($"Lucro RJ: {RJ / total:p2}");
    Console.WriteLine($"Lucro MG: {MG / total:p2}");
    Console.WriteLine($"Lucro ES: {ES / total:p2}");
    Console.WriteLine($"Lucro Outros estados: {OUTROS / total:p2}");
}