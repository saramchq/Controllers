using Microsoft.AspNetCore.Mvc;

namespace Exemplo_1.Controllers
{
    public class TextoController : Controller
    {
        //localhost:5220/pergunta1/resposta
        [Route("pergunta1/{nome}")]
        public string Pergunta1(string nome)
        {
            return "Olá, " + nome + "! Qual é a tua idade?";
        }

        //localhost:5220/pergunta2/resposta
        [Route("pergunta2/{idade}")]
        public string Pergunta2(int idade)
        {
            return "Já sei que tens " + idade + " anos. De qual cidade és?";
        }

        //localhost:5220/pergunta3/resposta

        [Route("pergunta3/{cidade}")]
        public string Pergunta3(string cidade)
        {
            return "E também sei que moras em " + cidade + ".";
        }
    }
}
 