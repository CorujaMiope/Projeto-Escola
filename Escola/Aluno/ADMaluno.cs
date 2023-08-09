using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using Escola.storage;
using Escola.Aluno;

namespace Escola
{
    internal class ADMaluno: Alunos
    {
       
        MenuAluno menuAluno = new MenuAluno();
        

        //CRIAÇÃO DE ALUNO
        public void CriarAluno()
        {
            var  metodoCriar = new Metodos_Criate_Aluno();

            nome = metodoCriar.NomeAluno();
            
            nascimento = metodoCriar.NascimentoAluno();
            
            sala = metodoCriar.Serie();

            idade = DateTime.Today.Year - nascimento.Year;

            ra = metodoCriar.RA();



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAluno cadastrado com sucesso");
            Console.ResetColor();

            Console.ReadLine();

            Alunos estudante = new Alunos(nome, idade, ra, sala, nascimento);
            Repositorio.ListaAluno.Add(estudante);
             
            

            MenuAluno menu = new MenuAluno();


            menu.Menu();
            

        }

      

        //FIM DE EDIÇÃO------------------------------------------------------

        //EXCLUIR UM ALUNO(A)
        public void ExcluirAluno()
        {
            Console.Clear();
            var menuAluno = new MenuAluno();

            Console.WriteLine("Qaul aluno sera excluido?\n\nLista de Alunos:\n");

            if (storage.Repositorio.ListaAluno.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A lista de Alunos está vazia.");
                Console.ResetColor();

                Thread.Sleep(2000);

                menuAluno.Menu();
            }

            var AlunosOrdenados = Repositorio.ListaAluno.OrderBy(a => a.nome).ToList();

            foreach (Alunos a in AlunosOrdenados)
            {
                Console.WriteLine($"\nALUNO: {a.nome}\nSALA: {a.sala}\nRA: {a.ra}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------------------");
                Console.ResetColor();
            }

            Console.Write("\nDigite o RA do aluno: ");
            string pegaRA = Console.ReadLine();
            int consulta;

            bool convertRA = int.TryParse(pegaRA, out consulta);

            if (convertRA)
            {
                Alunos ConsultaAlunos = storage.Repositorio.ListaAluno.Find(ListaAluno => ListaAluno.ra == consulta);

                if (ConsultaAlunos != null)
                {
                    Repositorio.ListaAluno.Remove(ConsultaAlunos);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nAluno removido com sucesso");
                    Console.ResetColor();

                    Console.ReadLine();

                    Console.Clear();

                    menuAluno.Menu();
                }

                else
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aluno não encontrado");
                    Console.ResetColor();

                    Console.ReadLine();

                    menuAluno.Menu();
                }
            }

        }

        

        public void VerNota()
        {

            

            var voltamenu = new MenuAluno();

            Console.Clear();
            Console.WriteLine("SELECIONE O ALUNO PELO NÚMERO DO RA\n\nLISTA DE ALUNOS:\n");

            if (storage.Repositorio.ListaAluno.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A lista de Alunos está vazia.");
                Console.ResetColor();

                Thread.Sleep(2000);

                menuAluno.Menu();
            }

            var AlunosOrdenados = Repositorio.ListaAluno.OrderBy(a => a.nome).ToList();

           

            foreach (Alunos a in AlunosOrdenados)
            {

                Console.WriteLine($"\nNOME: {a.nome} | SALA: {a.sala} | RA: {a.ra}\n\n\n");
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("-------------------------------------------------------");
                Console.ResetColor();
            }

            Console.Write("DIGITE O RA: ");
            string procurar = Console.ReadLine();
            int saida;
            bool converter = int.TryParse(procurar, out saida);
            var saida2 = saida;

            if (converter)
            {
                var ConsultaNota = Repositorio.NotasAluno.Where(a => a.Equals(saida2)).FirstOrDefault();
                
                    foreach (NotasDoAluno a in Repositorio.NotasAluno)
                    {

                        Console.WriteLine($"\nAluno: {a.nome} | Materia: {a.materia}\n\n1°NOTA: {a.n1} | 2°NOTA: {a.n2} | 3°NOTA: {a.n3} | 4°NOTA: {a.n4} | ");
                        Console.WriteLine($"\nMEDIA: {a.media} | SITUACÃO: {a.resultado}");
                }

                    Console.ReadLine();

                if (ConsultaNota != null)
                {
                    Console.Clear();
                    Console.WriteLine("NENHUMA NOTA CORRESPONDE A ESSE RA");

                    Thread.Sleep(1000);

                   
                  
                  
                }
                 menuAluno.Menu();
            }

            else { Console.Clear(); Console.WriteLine("VALOR INSERIDO INCORRETAMNETE"); Thread.Sleep(1000); Console.Clear(); menuAluno.Menu(); }
        }

        public void AtribuirNota()
        {
            Console.Clear();

            Console.WriteLine("ATRIBUIR NOTAS AO ALUNO:\n");

            Console.WriteLine("QUAL PROFESSOR IRÁ ATRIBUIR A NOTA?\n\nLISTA DE PROFESSORES:\n");

            if (storage.Repositorio.ListaProfessor.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A lista de professores está vazia.");
                Console.ResetColor();

                Thread.Sleep(2000);

                menuAluno.Menu();
            }

            var professoresOrdenados = Repositorio.ListaProfessor.OrderBy(p => p.nome).ToList();

            foreach (Professor p in professoresOrdenados)
            {
                Console.WriteLine($"\nPROFESSOR(A): {p.nome} | MATERIA: {p.materia} | ID: {p.id}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------------------------------------------------");
                Console.ResetColor();

            }



            Console.Write("\nDIGITE O ID DO PROFESSOR PARA SELECIONALO: ");
            string select = Console.ReadLine();
            int saida;
            bool converte = int.TryParse(select, out saida);

            if (converte)
            {
                int idd = saida;

                var ConsultaProfessor = Repositorio.ListaProfessor.Where(p => p.id.Equals(idd)).FirstOrDefault();



                if (ConsultaProfessor != null)
                {

                    Console.Clear();

                    Console.WriteLine("professor selecionado:".ToUpper());

                    Console.WriteLine($"\nPROFESSOR: {ConsultaProfessor.nome}\nMATERIA: {ConsultaProfessor.materia}\n");

                    Console.Write("\nAS NOTAS SERÃO ATRIBUIDAS A QUE ALUNO(A)?:\n");

                    Console.WriteLine("LISTA DE ALUNOS:\n");

                    if (storage.Repositorio.ListaAluno.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("A lista de Alunos está vazia.");
                        Console.ResetColor();

                        Thread.Sleep(2000);

                        menuAluno.Menu();
                    }

                    var AlunosOrdenados = Repositorio.ListaAluno.OrderBy(a => a.nome).ToList();

                    foreach (Alunos a in AlunosOrdenados)
                    {

                        Console.WriteLine($"\nNOME: {a.nome} | SALA: {a.sala} | RA: {a.ra}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("--------------------------------------------------");
                        Console.ResetColor();
                    }


                    Console.Write("\nDIGITE O RA DO ALUNO: ");
                    string RaDoAluno = Console.ReadLine();
                    int SaidaRa;
                    bool conv = int.TryParse(RaDoAluno, out SaidaRa);

                    if (conv)
                    {
                        int RAA = SaidaRa;

                        var ConsultaAluno = storage.Repositorio.ListaAluno.Where(a => a.ra.Equals(RAA)).FirstOrDefault();

                        if (ConsultaAluno != null)
                        {

                            Console.WriteLine("ALUNO SELECIONADO:");

                            Console.WriteLine($"\nALUNO(A): {ConsultaAluno.nome}\nSALA: {ConsultaAluno.sala}\nRA: {ConsultaAluno.ra}");

                            Console.ReadKey();

                            Console.Clear();

                            Console.WriteLine("DIGITE A 1° NOTA:");
                            string n1 = Console.ReadLine();
                            float nota1;
                            bool converterNota1 = float.TryParse(n1, out nota1);

                            while (!converterNota1 || nota1 > 10 || nota1 < 0)
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valor inválido");
                                Console.ResetColor();

                                Console.WriteLine("\nDIGITE A 1° NOTA:");
                                n1 = Console.ReadLine();
                                nota1 = 0;
                                converterNota1 = float.TryParse(n1, out nota1);

                            }

                            Console.Clear();

                            Console.WriteLine("\nDIGITE A 2° NOTA:");
                            string n2 = Console.ReadLine();
                            float nota2;
                            bool converterNota2 = float.TryParse(n2, out nota2);

                            while (!converterNota2 || nota2 > 10 || nota2 < 0)
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valor inválido");
                                Console.ResetColor();

                                Console.WriteLine("\nDIGITE A 2° NOTA:");
                                n2 = Console.ReadLine();
                                nota2 = 0;
                                converterNota2 = float.TryParse(n2, out nota2);

                            }

                            Console.Clear();

                            Console.WriteLine("\nDIGITE A 3° NOTA:");
                            string n3 = Console.ReadLine();
                            float nota3;
                            bool converterNota3 = float.TryParse(n3, out nota3);

                            while (!converterNota3 || nota3 > 10 || nota3 < 0)
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valor inválido");
                                Console.ResetColor();

                                Console.WriteLine("\nDIGITE A 3° NOTA:");
                                n3 = Console.ReadLine();
                                nota3 = 0;
                                converterNota2 = float.TryParse(n3, out nota3);
                            }

                            Console.Clear();

                            Console.WriteLine("\nDIGITE A 4° NOTA:");
                            string n4 = Console.ReadLine();
                            float nota4;
                            bool converterNota4 = float.TryParse(n4, out nota4);

                            while (!converterNota4 || nota4 > 10 || nota4 < 0)
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valor inválido");
                                Console.ResetColor();

                                Console.WriteLine("\nDIGITE A 4° NOTA:");
                                n4 = Console.ReadLine();
                                nota4 = 0;
                                converterNota2 = float.TryParse(n4, out nota4);
                            }

                            Console.Clear();

                            float media = (nota1 + nota2 + nota3 + nota4) / 4;

                            if (media >= 7.00)
                            {
                                var professor = ConsultaProfessor.nome;
                                var materia = ConsultaProfessor.materia;
                                var aluno = ConsultaAluno.nome;
                                var ra = ConsultaAluno.ra;

                                string linha1 = ("Nota 1 | Nota 2 | Nota 3 | Nota 4 | MEDIA FINAL");
                                string linha2 = ($"  {nota1}         {nota2}        {nota3}        {nota4}      {Math.Round(media)}");


                                var tabela = $"PROFESSOR: {professor} | MATERIA: {materia}\nALUNO: {aluno} | RA: {ra}\n{linha1}\n{linha2}\n"; Console.ResetColor();



                                string aprovado = "Aprovado";

                                string ma = materia.ToString();
                                string al = aluno.ToString();
                                int raAluno = ra;

                                var recebeNotas = new NotasDoAluno(ma, al, raAluno, nota1, nota2, nota3, nota4, media, aprovado);



                                storage.Repositorio.NotasAluno.Add(recebeNotas);

                                Console.Clear();

                                Console.WriteLine(tabela);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Aprovado");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("DIGITE ENTER");
                                Console.ReadLine();

                                Console.Clear();
                                Console.WriteLine("SAINDO...");
                                Thread.Sleep(1000);

                             



                            }

                            else
                            {
                                var professor = ConsultaProfessor.nome;
                                var materia = ConsultaProfessor.materia;
                                var aluno = ConsultaAluno.nome;
                                var ra = ConsultaAluno.ra;

                                string linha1 = ("Nota 1 | Nota 2 | Nota 3 | Nota 4 | MEDIA FINAL");
                                string linha2 = ($"  {nota1}         {nota2}        {nota3}        {nota4}      {Math.Round(media)}");



                                string tabela = $"PROFESSOR: {professor} | MATERIA: {materia}\n\nALUNO: {aluno} | RA: {ra}\n\n{linha1}\n{linha2}\n";

                                string reprovado = "Reprovado";

                                string ma = materia.ToString();
                                string al = aluno.ToString();
                                int raAluno = ra;

                                var recebeNotas = new NotasDoAluno(ma, al, raAluno, nota1, nota2, nota3, nota4, media, reprovado);

                                storage.Repositorio.NotasAluno.Add(recebeNotas);

                                Console.Clear();

                                Console.WriteLine(tabela);

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Reprovado");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("DIGITE ENTER");
                                Console.ReadLine();

                                Console.Clear();
                                Console.WriteLine("SAINDO...");
                                Thread.Sleep(1000);

                               



                            }
                            Console.WriteLine("DIGITE ENTER");
                            Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("SAINDO...");
                            Thread.Sleep(1000);

                           



                        }

                        else { Console.Clear(); Console.WriteLine("ALUNO NÃO ENCONTRADO"); Console.ReadLine(); }




                    }

                }

                else
                {
                    Console.Clear();

                    Console.WriteLine("\nPROFESSOR INEXISTENTE");

                    Thread.Sleep(1000);

                    


                }

            }

            menuAluno.Menu();
        }




    }


}
