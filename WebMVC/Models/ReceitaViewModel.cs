namespace WebMVC.Models
{
    public class ReceitaViewModel
    {
        public int Id { get; set; }

        public int IdCategoria { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Ingredientes { get; set; }

        public string ModoPreparo { get; set; }
    }
}
