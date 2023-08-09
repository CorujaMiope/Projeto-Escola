using Escola.Aluno;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.storage
{
    internal class Repositorio
    {
        public static List<Professor> ListaProfessor = new List<Professor>();

        public static List<Alunos> ListaAluno = new List<Alunos>();

        public static List<NotasDoAluno> NotasAluno = new List<NotasDoAluno>();
    }
}
