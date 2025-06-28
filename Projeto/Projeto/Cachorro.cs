using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Cachorro
    {
        // Atributos

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Valor { get; set; }


        //Metodos

        public float CalcularValorParcela(float valor, int parcela)
        {
            var resposta = valor / parcela;

            return resposta;
        }
    }
}
