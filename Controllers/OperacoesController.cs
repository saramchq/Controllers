using Microsoft.AspNetCore.Mvc;

namespace Exemplo_1.Controllers
{
    public class OperacoesController : Controller
    {
        [Route("add/{op2}/{op1}")]

        public String Adicionar(int op1, int op2)

        {
            int soma = op1 + op2;
            return "A soma é " + soma.ToString();
        }

        [Route("sub/{op1}/{op2}")]
        public String sub(int op1, int op2)
        {
            int resultado = op1 - op2;
            return "O resultado da subtração é " + resultado.ToString();
        }

        [Route("mult/{op1}/{op2}")]
        public String mult(int op1, int op2)
        {
            int resultado = op1 * op2;
            return "O resultado da multiplicação é " + resultado.ToString();
        }

        [Route("div/{op1}/{op2}")]
        public String div(int op1, int op2)
        {
            int resultado = op1 / op2;
            return "O resultado da divisão é " + resultado.ToString();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
