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
            Personne p1 = new Personne(30,"Dupont","Paul");
            Console.WriteLine("L'age de " + p1.Name + " est : " + p1.Age);
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.ReadKey();
        }
    }
}
