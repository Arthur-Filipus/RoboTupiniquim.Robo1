using System.Reflection;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do grid X: ");

            int gridx = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o tamanho do grid Y: ");
            
            int gridy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Robo1");

            Console.Write("Digite a posição inicial X: ");

            int posinicialx1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posição inicial Y: ");

            int posinicialy1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a direção do Robo em (N) (S) (L) (O): ");

            char direcao1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Digite o comando para o robo fazer: ");

            string comando1 = Console.ReadLine();

            char[] comandochar1 = comando1.ToCharArray();

            for (int i = 0; i < comandochar1.Length; i++)
            {
                if (comandochar1[i] == 'M')
                {
                    if (direcao1 == 'N')
                    {
                        posinicialy1++;
                    }
                    else if (direcao1 == 'S')
                    {
                        posinicialy1--;
                    }
                    else if (direcao1 == 'L')
                    {
                        posinicialx1++;
                    }
                    else if (direcao1 == 'O')
                    {
                        posinicialx1--;
                    }
                }
                else if (comandochar1[i] == 'E')
                {
                    if (direcao1 == 'N')
                    {
                        direcao1 = 'O';
                    }
                    else if (direcao1 == 'O')
                    {
                        direcao1 = 'S';
                    }
                    else if (direcao1 == 'S')
                    {
                        direcao1 = 'L';
                    }
                    else if (direcao1 == 'L')
                    {
                        direcao1 = 'N';
                    }
                }
                else if (comandochar1[i] == 'D')
                {
                    if (direcao1 == 'N')
                    {
                        direcao1 = 'L';
                    }
                    else if (direcao1 == 'L')
                    {
                        direcao1 = 'S';
                    }
                    else if (direcao1 == 'S')
                    {
                        direcao1 = 'O';
                    }
                    else if (direcao1 == 'O')
                    {
                        direcao1 = 'N';
                    }
                }
            }

            Console.WriteLine("Robo2");

            Console.Write("Digite a posição inicial X: ");

            int posinicialx2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posição inicial Y: ");

            int posinicialy2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a direção do Robo em (N) (S) (L) (O): ");

            char direcao2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Digite o comando para o robo fazer: ");

            string comando2 = Console.ReadLine();

            char[] comandochar2 = comando2.ToCharArray();

            for (int i = 0; i < comandochar2.Length; i++)
            {
                if (comandochar2[i] == 'M')
                {
                    if (direcao2 == 'N')
                    {
                        posinicialy2++;
                    }
                    else if (direcao2 == 'S')
                    {
                        posinicialy2--;
                    }
                    else if (direcao2 == 'L')
                    {
                        posinicialx2++;
                    }
                    else if (direcao2 == 'O')
                    {
                        posinicialx2--;
                    }
                }
                else if (comandochar2[i] == 'E')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'S';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'N';
                    }
                }
                else if (comandochar2[i] == 'D')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'N';
                    }
                }
            }
            Console.WriteLine($"Robo1: {posinicialx1} , {posinicialy1} {direcao1}");

            Console.WriteLine($"Robo2: {posinicialx2} , {posinicialy2} {direcao2}");

            Console.ReadLine();
        }
    }
}