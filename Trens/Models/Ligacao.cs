using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trens.Model
{
    //representa arestas
    //guarda ligacao entreas cidades
    public class Ligacao
    {

        public double Distancia { get; set; }

        public double Preco { get; set; }

        public Ligacao (double distancia, double preco)
        {
            this.Distancia = distancia;
            this.Preco= preco;
        }

        public override string ToString()
        {
            return "Distância: " + this.Distancia + ". Preço: " + this.Preco;
        }
    }

}
