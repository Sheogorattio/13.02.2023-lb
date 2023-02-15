using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023_lb
{
    public class Passport
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { set; get;}
        public int Number { get; set; }
    }

    public class ForeignPassport : Passport
    {
        private string[] visas;
        public ForeignPassport()
        {
            visas = new string[0];
        }

        public void AddVisa(string Country)
        {
            string[] _visas = new string[visas.Length+1];
            for(int i=0; i < _visas.Length; i++)
            {
                _visas[i] = visas[i];
            }
            _visas[_visas.Length-1] = Country;
            visas = _visas;
        }

        public string this[int i]
        {
            get
            {
                return visas[i];
            }
            set
            {
                visas[i] = value;
            }
        }
    }
}
