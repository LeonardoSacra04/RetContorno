int largura, altura;
int linha, coluna;

Console.Clear();

Console.WriteLine("Defina o tamanho do retângulo");
Console.Write("Largura:.. ");
largura = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Altura:... ");
altura = Convert.ToInt32(Console.ReadLine()!);

if (largura < 1 || largura > 10 || altura < 1 || altura > 10)
{
    Console.WriteLine("A largura e altura deve ter valores entre 1 e 10!");
}
else
{
    linha = 1;
    while (linha <= altura)
    {
        Console.WriteLine();

        coluna = 1;
        while (coluna <= largura)
        {

            if (linha == 1 || linha == altura)
            {
                Console.Write("*");
            }
            else
            {
                if (coluna == 1 || coluna == largura)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            coluna += 1;
        }

        linha += 1;
    }
}
