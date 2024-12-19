namespace Exemplo02.Models
{
    public class Cliente
    {
        private string nome;
        private string morada;

        public Cliente(string n, string m)
        {
            nome = n;
            morada = m;
        }

        public Cliente()
        {
            nome = "babalu";
            morada = "rua do mocho";
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetMorada()
        {
            return morada;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetMorada(string morada)
        {
            this.morada = morada;
        }



    }
}
