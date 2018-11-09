using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllGitHubLocal
{
    public class Personne
    {
        private int _Age;
        string _Prenom;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Telephone;

        public int Telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }


        public Personne(string st)
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }
        public Personne(int age,string name, string prenom)
        {
            _Age = age;
            _Name = name;
            _Prenom = prenom;
            Name = st;
        }
    }
}
