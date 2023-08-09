using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Escola
{
    internal class CriarProfessor
    {
        public string NomeProfessor()
        {
            Console.Clear();

            Console.Write("\nDigite o nome do Professor(a): ");
            string nome = Console.ReadLine().ToUpper();

            int conta = nome.Count();

            bool VerificarString = Regex.IsMatch(nome, @"[^a-zA-ZÀ-ÿ\s]");

            while (conta < 3 || VerificarString)
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite apenas letras");
                Console.ResetColor();

                Console.Write("\nDigite o nome do Professor(a): ");
                nome = Console.ReadLine().ToUpper();

                conta = nome.Count();

                VerificarString = Regex.IsMatch(nome, @"[^a-zA-ZÀ-ÿ\s]");

            }

            return nome;
        }

        public enum TabelaMateria : int
        {
            PORTUGUÊS = 1,
            SOCIOLOGIA = 2,
            FILOSOFIA = 3,
            ARTES = 4,
            HISTÓRIA = 5,
            MATEMATICA = 6,
            QUIMICA = 7,
            BIOLOGIA = 8,
            FÍSICA = 9,
            ED_FÍSICA = 10,
            GEOGRAFIA = 11,
            INGLÊS = 12
        }

        public string EscolheMateria()
        {


            Console.Write("\nEM QUE MATÉRIA O MESMO LECIONARA?:\n ");

            //TABELA
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1--PORTUGUÊS\n2--SOCIOLOGIA\n3--FILOSOFIA\n4--ARTES\n5--HISTÓRIA\n6--MATEMÁTICA".ToUpper());
            Console.WriteLine("7--QUIMICA\n8--BIOLOGIA\n9--FÍSICA\n10--ED.FÍSICA\n11--GEOGRAFIA\n12--INGLÊS".ToUpper());
            Console.ResetColor();

            //AREA DE DIGITAÇÃO
            Console.Write("DIGITE O NÚMERO ATRIUIDO A MATERIA: ");
            string escolha = Console.ReadLine();
            int nummateria;
            bool converterPraNumero = int.TryParse(escolha, out nummateria);
            

            while (!converterPraNumero || nummateria < 1 || nummateria > 12)
            {
                Console.Clear();

                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Valor inválido\n");
                Console.ResetColor();
                Console.Write("\nEM QUE MATÉRIA O MESMO LECIONARA?:\n ");

                //TABELA
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1--PORTUGUÊS\n2--SOCIOLOGIA\n3--FILOSOFIA\n4--ARTES\n5--HISTÓRIA\n6--MATEMÁTICA".ToUpper());
                Console.WriteLine("7--QUIMICA\n8--BIOLOGIA\n9--FÍSICA\n10--ED.FÍSICA\n11--GEOGRAFIA\n12--INGLÊS".ToUpper());
                Console.ResetColor();

                //AREA DE DIGITAÇÃO
                Console.Write("DIGITE O NÚMERO ATRIUIDO A MATERIA: ");
                escolha = Console.ReadLine();
                nummateria = 0;
                converterPraNumero = int.TryParse(escolha, out nummateria);
            }

            var materia = ((TabelaMateria)nummateria).ToString();

            return materia;

        }

        public int idP()
        {
            var rand = new Random();

            var id = rand.Next(300,400);

            return id;  
        }
    }
}
