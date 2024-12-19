using Microsoft.AspNetCore.Mvc;

namespace Exemplo_1.Controllers
{
    public class MinEMaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("min/{op}/{op2}/{op3}")]

        public String minimo(int op1, int op2, int op3)
        {
            int minimo = Math.Min(op1, op2);
            minimo = Math.Min(minimo, op3);

            return "mínimo: " + minimo;
        }

        [Route("max/{op}/{op2}/{op3}")]

        public String maximo(int op1, int op2, int op3)
        {
            int maximo = Math.Max(op1, op2);
            maximo = Math.Max(maximo, op3);

            return "máximo: " + maximo;
        }

    }
}
