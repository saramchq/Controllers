using Microsoft.AspNetCore.Mvc;

namespace Exemplo_1.Controllers
{
    public class TabuadaController : Controller
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

        [Route("tabuada0/{valor}")]

        public string TabuadaSimples(int valor)
        {
            string s = "";
            for (int i = 1; i < 10; i++)
            {
                s = s + valor + "x" + i + "=" + (valor * i) + "\n";
            }
            return s;
        }
        [Route("TabuadaGira/{valor}/{cor}")]

        public ContentResult tabuadagira(int valor, String cor)
        {
            ContentResult c1 = new ContentResult();
            c1.ContentType = "text/html";
            String s = "<html><body><table border = 1 style='background-color:"+cor+"'>";

            for (int i = 1; i <= 10; i++)
            {
                s = s + "<tr><td>" + valor + "x" + i + "=" + valor * i + "</td></tr>";
            }
            s = s + "</table></body></html>";
            
            c1.Content = s;
            return c1;
        }
    }
}
