using DllGitHubLocal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeur
{
    public class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Age = 21;
            Console.WriteLine("L'age de " + p1.Name + " est : " + p1.Age);
            Console.ReadKey();
        }
    }
}
