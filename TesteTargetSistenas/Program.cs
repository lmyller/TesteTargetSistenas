Soma();

void Soma()
{
    int INDICE = 13,
    SOMA = 0,
    K = 0;

    while (K < INDICE)
    {
        K = K + 1;
        SOMA = SOMA + K;
    }

    Imprimir(SOMA);
}

void Imprimir(int soma)
{
    //Resultado = 91
    Console.WriteLine(soma);
}