<<<<<<< HEAD
﻿using Escola.storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Escola
{
    public class Metodos_Criate_Aluno
    {
        public string NomeAluno()
        {
            var voltaMenuAluno = new MenuAluno();

            Console.Clear();

            Console.Write("\nDigite o nome do aluno(a): ");
            string nome = Console.ReadLine().ToUpper();

            int conta = nome.Count();

            bool VerificarString = Regex.IsMatch(nome, @"[^a-zA-ZÀ-ÿ\s]");

            while (conta < 3 || VerificarString) {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite apenas letras e nomes com no mínimo três letras. Ex: Ana");
                Console.ResetColor();

                Console.Write("\nDigite o nome do aluno(a): ");
                nome = Console.ReadLine().ToUpper();

                conta = nome.Count();

                VerificarString = Regex.IsMatch(nome, @"[^a-zA-ZÀ-ÿ\s]");

            }

            

            return nome;
        }

        public DateTime NascimentoAluno()
        {
            Console.Clear();

            Console.WriteLine("\nQual é a data de nascimento do aluno?\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite nesse formato dd/mm/aaaa: ");
            Console.ResetColor();

            DateTime AlunoData;
            bool DataConvert = DateTime.TryParse(Console.ReadLine(), out AlunoData);

            int idade = DateTime.Today.Year - AlunoData.Year;

            while (idade < 6 || idade > 19 || !DataConvert)
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido\nO aluno tem que ter no minimo 6 anos e no máximo 19 anos");
                Console.ResetColor();

                Console.WriteLine("\nQual é a data de nascimento do aluno?\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nDigite nesse formato dd/mm/aaaa: ");
                Console.ResetColor();
                string novaData = Console.ReadLine();


                DataConvert = DateTime.TryParse(novaData, out AlunoData);
                idade = DateTime.Today.Year - AlunoData.Year;
            }

            return AlunoData;
        }

        public int ObterIdadade()
        {
            var nascimento = NascimentoAluno();

            int idade = DateTime.Today.Year - nascimento.Year;

            return idade;
        }



        public enum sala : int
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4
        }

        public string Serie()
        {
            Console.Clear();

            string resultado = " ";

            Console.Write("\nEM QUAL SÉRIE O ALUNO(A) IRA ESTUDAR? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEx: 1 ou 9: ");
            Console.ResetColor();

            string serie = Console.ReadLine();
            int serieconfirm;
            bool confirmar = int.TryParse(serie, out serieconfirm);
            int contaSerie = serie.Count();

            if (confirmar && serieconfirm >0 && serieconfirm < 10)
            {
=======
﻿using Escola.storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Escola
{
    public class Metodos_Criate_Aluno
    {
        public string NomeAluno()
        {
            Console.Clear();

            Console.Write("\nDigite o nome do aluno(a): ");
            string nome = Console.ReadLine().ToUpper();

            int conta = nome.Count();

            bool VerificarString = Regex.IsMatch(nome, @"[^a-zA-ZÀ-ÿ\s]");

            while (conta < 3 || VerificarString) {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite apenas letras");
                Console.ResetColor();

                Console.Write("\nDigite o nome do aluno(a): ");
                nome = Console.ReadLine().ToUpper();

                conta = nome.Count();

                VerificarString = Regex.IsMatch(nome, @"[^a-zA-ZÀ-ÿ\s]");

            }

            return nome;
        }

        public DateTime NascimentoAluno()
        {
            Console.Clear();

            Console.WriteLine("\nQual é a data de nascimento do aluno?\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite nesse formato dd/mm/aaaa: ");
            Console.ResetColor();

            DateTime AlunoData;
            bool DataConvert = DateTime.TryParse(Console.ReadLine(), out AlunoData);

            int idade = DateTime.Today.Year - AlunoData.Year;

            while (idade < 6 || idade > 20 || !DataConvert)
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido");
                Console.ResetColor();

                Console.WriteLine("\nQual é a data de nascimento do aluno?\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nDigite nesse formato dd/mm/aaaa: ");
                Console.ResetColor();


                DataConvert = DateTime.TryParse(Console.ReadLine(), out AlunoData);
            }

            return AlunoData;
        }

        public int ObterIdadade()
        {
            var nascimento = NascimentoAluno();

            int idade = DateTime.Today.Year - nascimento.Year;

            return idade;
        }



        public enum sala : int
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4
        }

        public string Serie()
        {
            Console.Clear();

            string resultado = " ";

            Console.Write("\nEM QUAL SÉRIE O ALUNO(A) IRA ESTUDAR? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEx: 1 ou 9: ");
            Console.ResetColor();

            string serie = Console.ReadLine();
            int serieconfirm;
            bool confirmar = int.TryParse(serie, out serieconfirm);
            int contaSerie = serie.Count();

            if (confirmar && serieconfirm >0 && serieconfirm < 10)
            {
>>>>>>> c9f32b686204af0dd99e23fa665e61fdead93f08
                Console.WriteLine("Em qual sala o aluno(a) ira estudar ?:\n");
                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.WriteLine("1-- A | 2-- B");
                Console.WriteLine("3-- C | 4-- D\n");
<<<<<<< HEAD
                Console.ResetColor();

                Console.Write("Digite: ");
                string digito = Console.ReadLine();
                int letra;
                bool convertletra = int.TryParse(digito, out letra);
                
                while (!convertletra || letra < 1 || letra > 4)  
                {
                        Console.Clear();


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor inválido");
                        Console.ResetColor();

                        Console.WriteLine("\nEm qual sala o aluno(a) ira estudar ?:\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("1-- A | 2-- B");
                        Console.WriteLine("3-- C | 4-- D\n");
                        Console.ResetColor();

                        Console.Write("Digite: ");
                        digito = Console.ReadLine();
                        letra = 0;
                        convertletra = int.TryParse(digito, out letra);
                        


                }
                    
                        var salaserie = (sala)letra;
                    resultado = serieconfirm.ToString() + salaserie.ToString();

                   
               
            }

            else
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido");
                Console.ResetColor();

                Console.ReadLine();

                Serie();
            }

            return resultado;
        }

        public int RA()
        {
            var rand = new Random();

            int num = rand.Next(100, 300);

            while(Repositorio.ListaAluno.Any(a => a.ra == num))
            {
                rand = new Random();
                num = rand.Next(100, 300);

            }

            return num;
        }



       

       
    }
}
=======
                Console.ResetColor();

                Console.Write("Digite: ");
                string digito = Console.ReadLine();
                int letra;
                bool convertletra = int.TryParse(digito, out letra);
                
                while (!convertletra || letra < 1 || letra > 4)  
                {
                        Console.Clear();


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor inválido");
                        Console.ResetColor();

                        Console.WriteLine("\nEm qual sala o aluno(a) ira estudar ?:\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("1-- A | 2-- B");
                        Console.WriteLine("3-- C | 4-- D\n");
                        Console.ResetColor();

                        Console.Write("Digite: ");
                        digito = Console.ReadLine();
                        letra = 0;
                        convertletra = int.TryParse(digito, out letra);
                        


                }
                    
                        var salaserie = (sala)letra;
                    resultado = serieconfirm.ToString() + salaserie.ToString();

                    Console.WriteLine(resultado);

                    Console.ReadLine(); 
               
            }

            else
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido");
                Console.ResetColor();

                Console.ReadLine();

                Serie();
            }

            return resultado;
        }

        public int RA()
        {
            var rand = new Random();

            int num = rand.Next(100, 300);

            return num;
        }



       

       
    }
}
>>>>>>> c9f32b686204af0dd99e23fa665e61fdead93f08
