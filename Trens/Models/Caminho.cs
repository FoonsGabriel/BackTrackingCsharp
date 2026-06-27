using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trens.Estruturas;

namespace Trens.Model
{

    //guarda resultado de busca
    public class Caminho
    {
        public List<Cidade> Cidades { get; set; }

        public double DistanciaTotal { get; set; }

        public double PrecoTotal { get; set; }

        public Caminho()
        {
            Cidades = new List<Cidade>();
        }

        public override string ToString()
        {
            string resultado = "";

            for (int i = 0; i < Cidades.Count; i++)
            {
                resultado += Cidades[i].Nome;

                if (i < Cidades.Count - 1)
                    resultado += ">";
            }

            return resultado;
        }
    }
}
