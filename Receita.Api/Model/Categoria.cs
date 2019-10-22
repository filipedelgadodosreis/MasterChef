using System.Collections.Generic;

namespace Receita.Api.Model
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public IEnumerable<Receita> Receitas { get; set; }
    }
}
