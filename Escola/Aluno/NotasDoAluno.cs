using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Aluno
{
    internal class NotasDoAluno
    {
        public string materia { get; set; }
        public string nome { get; set; }
        public int ra { get; set; }
        public float n1 { get; set; }
        public float n2 { get; set; }
        public float n3 { get; set; }
        public float n4 { get; set; }
        public float media { get; set; }

        public string resultado { get; set; }
        
        public NotasDoAluno() { }

        public NotasDoAluno(string Materia, string Nome, int Ra, float N1, float N2, float N3, float N4, float Media, string Resultado)
        {
            this.materia = Materia;
            this.nome = Nome;
            this.ra = Ra;
            this.n1 = N1;
            this.n2 = N2;
            this.n3 = N3;
            this.n4 = N4;
            this.media = Media;
            this.resultado = Resultado;
        }
    }
}
