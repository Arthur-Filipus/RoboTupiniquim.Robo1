using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                PosicaoInicialRobo();

                MovimentacaoRobo();  
            }
        }

        #region Variáveis Globais
        static int posinicialx;
        static int posinicialy;
        static char direcao;
        static string comando;
        static char[] comandochar;
        static int robo;
        static int nomerobo;
        #endregion

        public static void PosicaoInicialRobo()
        {
            nomerobo++;
            
            Console.WriteLine($"Robo{nomerobo}");

            Console.Write("Digite a posição inicial X: ");

            posinicialx = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posição inicial Y: ");

            posinicialy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a direção do Robo em (N) (S) (L) (O): ");

            direcao = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Digite o comando para o robo fazer: ");

            comando = Console.ReadLine().ToUpper();

            comandochar = comando.ToCharArray();
        }

        public static void MovimentacaoRobo()
        {
            for (int i = 0; i < comandochar.Length; i++)
            {
                if (comandochar[i] == 'M')
                {
                    if (direcao == 'N')
                    {
                        posinicialy++;
                    }
                    else if (direcao == 'S')
                    {
                        posinicialy--;
                    }
                    else if (direcao == 'L')
                    {
                        posinicialx++;
                    }
                    else if (direcao == 'O')
                    {
                        posinicialx--;
                    }
                }
                else if (comandochar[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'N';
                    }
                }
                else if (comandochar[i] == 'D')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }
                }                
            }
            robo++;

            Console.WriteLine($"Robo{robo}: {posinicialx} , {posinicialy} {direcao}");

            Console.WriteLine();
        }
    }
}