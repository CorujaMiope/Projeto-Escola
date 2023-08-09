using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Alunos
    {
        public string nome { get; set; }

        public DateTime nascimento { get; set; }

        public int idade { get; set; }

        public int ra { get; set; }

        public string sala { get; set; }




        public Alunos()
        {
            
        }


        //CONSTRUTOR
        public Alunos(string Nome, int Idade, int RA, string Sala, DateTime Nascimento)
        {
            nome = Nome;
            idade = Idade;
            ra = RA;
            sala = Sala;
            nascimento = Nascimento;
        }

    }
}
