using System.Collections.Generic;

namespace WebMVC.Models
{
    public class ReceitaViewModel
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public List<Receita> Data { get; set; }
    }
}
