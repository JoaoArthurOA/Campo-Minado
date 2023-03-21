using System;

namespace campominado
{
    class Program
    {
        static void Main(string[] args)
        {
            int posi;
            int vito;
            int[,] campo = new int[4, 4];
            campo[0, 0] = 0; campo[1, 0] = 0; campo[2, 0] = 0; campo[3, 0] = 0;
            campo[0, 1] = 0; campo[1, 1] = 0; campo[2, 1] = 0; campo[3, 1] = 0;
            campo[0, 2] = 0; campo[1, 2] = 0; campo[2, 2] = 0; campo[3, 2] = 0;
            campo[0, 3] = 0; campo[1, 3] = 0; campo[2, 3] = 0; campo[3, 3] = 0;

            vito = 0;
            while (vito != 12)
            {
                string campos = " ";
                for (int linha = 0; linha < 4; linha++)
                {
                    for (int coluna = 0; coluna < 4; coluna++)
                    {
                        campos += campo[linha, coluna] + " ";
                    }
                    Console.WriteLine(campos);
                    campos = " ";
                }
                Console.WriteLine("Dê uma posição do campo ");
                posi = Convert.ToInt32(Console.ReadLine());

                if (posi == 11)
                {
                    campo[0, 0] = 1;
                    vito++;
                }

                if (posi == 12)
                {
                    campo[0, 1] = 5;
                    Console.WriteLine("você achou uma bomba, perdeu o jogo");
                    for (int linha = 0; linha < 4; linha++)
                    {
                        for (int coluna = 0; coluna < 4; coluna++)
                        {
                            campos += campo[linha, coluna] + " ";
                        }
                        Console.WriteLine(campos);
                        campos = " ";
                    }
                    Environment.Exit(0);
                }
                if (posi == 13)
                {
                    campo[0, 2] = 2;
                    vito++;
                }
                if (posi == 14)
                {
                    campo[0, 3] = 5;
                    for (int linha = 0; linha < 4; linha++)
                    {
                        for (int coluna = 0; coluna < 4; coluna++)
                        {
                            campos += campo[linha, coluna] + " ";
                        }
                        Console.WriteLine(campos);
                        campos = " ";
                    }
                    Environment.Exit(0);
                }
                if (posi == 21)
                {
                    campo[1, 0] = 1;
                    vito++;
                }
                if (posi == 22)
                {
                    campo[1, 1] = 2;
                    vito++;
                }
                if (posi == 23)
                {
                    campo[1, 2] = 3;
                    vito++;
                }
                if (posi == 24)
                {
                    campo[1, 3] = 2;
                    vito++;
                }
                if (posi == 31)
                {
                    campo[2, 0] = 1;
                    vito++;
                }
                if (posi == 32)
                {
                    campo[2, 1] = 2;
                    vito++;
                }
                if (posi == 33)
                {
                    campo[2, 2] = 5;
                    for (int linha = 0; linha < 4; linha++)
                    {
                        for (int coluna = 0; coluna < 4; coluna++)
                        {
                            campos += campo[linha, coluna] + " ";
                        }
                        Console.WriteLine(campos);
                        campos = " ";
                    }
                    Environment.Exit(0);
                }
                if (posi == 34)
                {
                    campo[2, 3] = 1;
                    vito++;
                }
                if (posi == 41)
                {
                    campo[3, 0] = 2;
                    for (int linha = 0; linha < 4; linha++)
                    {
                        for (int coluna = 0; coluna < 4; coluna++)
                        {
                            campos += campo[linha, coluna] + " ";
                        }
                        Console.WriteLine(campos);
                        campos = " ";
                    }
                    Environment.Exit(0);
                }
                if (posi == 42)
                {
                    campo[3, 1] = 2;
                    vito++;
                }
                if (posi == 43)
                {
                    campo[3, 2] = 1;
                    vito++;
                }
                if (posi == 44)
                {
                    campo[3, 3] = 1;
                    vito++;
                }
            }
            if (vito == 12)
            {
                string campos = " "; 
                for (int linha = 0; linha < 4; linha++)
                {
                    for (int coluna = 0; coluna < 4; coluna++)
                    {
                        campos += campo[linha, coluna] + " ";
                    }
                    Console.WriteLine(campos);
                    campos = " ";
                }
                Console.WriteLine("Você evitou todas as bombas, venceu o jogo");
            }



        }     
    }
}

