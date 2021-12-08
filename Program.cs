using System;

namespace POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 2;

            while (x != 0)
            {
                retang ret1;
                ret1 = new retang();
                Console.WriteLine("Informe a Alt:");
                ret1.Alt = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe a Larg:");
                ret1.Larg = float.Parse(Console.ReadLine());
                Console.WriteLine("_________________________________");
                Console.WriteLine($"Area : {ret1.Area()}");
                Console.WriteLine($"Diagonal : {ret1.Diag()}");
                Console.WriteLine($"Perimetro : {ret1.Per()}");
                Console.WriteLine("_________________________________");
                Console.WriteLine("Quer Continuar?\n0-Não\n1-Sim");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Bye-Bye!!!");
                    break;
                }else if (x == 1)
                {
                    Console.WriteLine("OK!!");
                }
                else
                {
                    Console.WriteLine("Opção Invalida!!! Reiniciado!");
                }
            }
        }
    }
}
