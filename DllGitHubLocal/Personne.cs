﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllGitHubLocal
{
    public class Personne
    {
        private int _Age;

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
        public Personne(string st)
        {

        }
    }
}
