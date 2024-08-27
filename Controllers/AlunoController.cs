using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Cristiano de Paula", "cristiano.paula@sp.senai.br", 123456);
            Aluno a2 = new Aluno(2, "Maria aparecida", "maria.aparecida@sp.senai.br", 2345671);
            Aluno a3 = new Aluno(3, "José da Silva", "jose.silva@sp.senai.br", 3456712);
            Aluno a4 = new Aluno(4, "Bianca Furlanetto", "bianca.furlanetto@sp.senai.br", 4567123);
            Aluno a5 = new Aluno(5, "Helena Cristina", "helena.cristina@sp.senai.br", 5671234);

            //criar uma lista de alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //adicionar os Objetos alunos na lista alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            //enviando a lista de alunos por parametro na view index
            return View(listaAlunos);

        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
