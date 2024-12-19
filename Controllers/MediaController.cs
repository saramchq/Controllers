using Microsoft.AspNetCore.Mvc;

namespace Exemplo_1.Controllers
{
    public class MediaController : Controller
    {

        [Route("media/{n1}/{n2}/{n3}")]
        public String media(int n1, int n2, int n3)
        {
            int resultado = (n1 + n2 + n3) / 3;
            return "A média é " + resultado.ToString();
        }

        [Route("media/tabela/{n1}/{n2}/{n3}")]
        public ContentResult mediaComTabela(int n1, int n2, int n3)
        {
            ContentResult c1 = new ContentResult();
            c1.ContentType = "text/html";

            int media = (n1 + n2 + n3) / 3;
            String tabela = "<table border=1 style='background-color:pink'>";

            tabela = tabela + "<tr><td>Media: " + media + "</td></tr>";
            tabela = tabela + "</tr></table>";

            c1.Content = tabela;
            return c1;
        }

    }
}
