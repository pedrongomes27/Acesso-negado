using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso_negado
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = Console.ReadLine();
            while (senha != "admin123")
            {
                Console.WriteLine("Senha incorreta, por favor tente novamente");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Senha Correta");
            Console.ReadKey();

        }
    }
}
