using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.Site.Areas.Produtos.Controllers
{
    [Area("Vendas")]
    public class PedidosController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}