using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trens.Models
{
    public class Movimento : IComparable<Movimento>
    {
        public int Origem { get; set; }

        public int Destino { get; set; }

        public double Distancia { get; set; }

        public double Preco { get; set; }

        public Movimento(
            int origem,
            int destino,
            double distancia,
            double preco)
        {
            Origem = origem;
            Destino = destino;
            Distancia = distancia;
            Preco = preco;
        }

        public override string ToString()
        {
            return Origem + " -> " + Destino;
        }

        public int CompareTo(Movimento other)
        {
            return Origem.CompareTo(other.Origem);
        }
    }
}
