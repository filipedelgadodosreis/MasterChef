namespace Receita.Api.Model
{
    public class Receita
    {
        public int Id { get; set; }

        public int IdCategoria { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Ingredientes { get; set; }

        public string ModoPreparo { get; set; }

        public Categoria Categoria { get; set; }
    }
}
