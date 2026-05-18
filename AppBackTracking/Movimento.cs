using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBackTracking
{
    internal class Movimento : IComparable<Movimento>
    {
        private int origem, destino;

        public int CompareTo(Movimento outro) //so para deixar compativel com a pilha que pede IComparable
        {
            return 0; //não comparamos movimentos, meio que uma gambiarra
        }

        public Movimento(int or, int dest)
        {
            origem = or;
            destino = dest;
        }

        public int Origem { get => origem; set => origem = value; }

        public int Destino { get => destino; set => destino = value; }

        public override String ToString()
        {
            return origem + " " + destino;
        }


    }
}
