using Microsoft.AspNetCore.Mvc;

namespace Exemplo_1.Controllers
{
    public class TabelaController : Controller
    {
        [Route("criartabela/{linhas}/{colunas}/{cor}")]
        public ContentResult CriarTabela(int linhas, int colunas, string cor)
        {
            ContentResult c1 = new ContentResult();
            c1.ContentType = "text/html";

            String tabela = "<table border=1'>";

            for (int i = 0; i < linhas; i++)
            {
                tabela = tabela + "<tr>";
                for (int j = 0; j < colunas; j++)
                {
                    tabela = tabela + "<td style='background-color:" + cor + "; padding:10px'>Sara</td>";
                }
                tabela = tabela + "</tr>";
            }

            tabela = tabela + "</table>";

            c1.Content = tabela;
            return c1;
        }
    }
}