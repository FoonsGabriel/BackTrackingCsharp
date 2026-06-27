using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Trens.Model
{
    //guarda dados das cidades
    public class Cidade : IComparable<Cidade>
    {

        public string Nome { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public Cidade (string nome, double x, double y)
        {
            this.Nome = nome;
            this.X = x;
            this.Y = y;
        }

        public int CompareTo(Cidade outra)
        {
            return Nome.CompareTo(outra.Nome);
        }

        public override string ToString()
        {
            //assim qlqr lugar que pegar cidade retorna o nome dela
            return Nome;
        }   
    }
}
