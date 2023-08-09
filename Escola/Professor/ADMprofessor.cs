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
    internal class ADMprofessor: Professor
    {
        MenuProfessor voltamenu = new MenuProfessor();

        public void ProfessoresCadastro()
        {
            var criarprof = new CriarProfessor();

            nome = criarprof.NomeProfessor();
            materia = criarprof.EscolheMateria();
            id = criarprof.idP();

            Professor professor = new Professor(nome,materia,id);
            Repositorio.ListaProfessor.Add(professor);
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nProfessor cadastrado com sucesso");
            Console.ResetColor();

            Console.ReadLine();

            var menu = new MenuProfessor();

            menu.Menu();
        }



        public void Editor()
        {
            if (storage.Repositorio.ListaProfessor.Count == 0)
            {   
                Console.ForegroundColor= ConsoleColor.Blue;    
                Console.WriteLine("A lista de professores está vazia.");
                Console.ResetColor();

                Thread.Sleep(2000);

                voltamenu.Menu();
            }

            Console.Clear();
            var menuprof = new MenuProfessor();

            Console.WriteLine("Qaul professor sera excluido?\n\nLista de Professores:\n");

            var professoresOrdenados = Repositorio.ListaProfessor.OrderBy(p => p.nome).ToList();

            foreach (Professor p in professoresOrdenados)
            {
                Console.WriteLine($"\nPROFESSOR: {p.nome}\nMATERIA: {p.materia}\nID: {p.id}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------------------");
                Console.ResetColor();
            }

            Console.Write("\nDigite o ID do professor: ");
            string pegaId = Console.ReadLine();
            int consulta;

            bool convertID = int.TryParse(pegaId, out consulta);

            if(convertID )
            {
                Professor ConsultaProfessor = storage.Repositorio.ListaProfessor.Find(Professor => Professor.id == consulta);

                if(ConsultaProfessor != null)
                {
                    Repositorio.ListaProfessor.Remove(ConsultaProfessor);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nProfessor removido com sucesso");
                    Console.ResetColor();

                    Console.ReadLine();

                    Console.Clear();

                    menuprof.Menu();
                }

                else
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Professor não encontrado");
                    Console.ResetColor();

                    Console.ReadLine();

                    menuprof.Menu();
                }
            }

           


        }

           
           
           

        }




    }

