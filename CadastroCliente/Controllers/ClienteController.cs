using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Atualizar()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }
    }
}