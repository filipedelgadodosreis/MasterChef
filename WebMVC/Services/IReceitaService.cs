using WebMVC.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebMVC.Services
{
    public interface IReceitaService
    {
        Task<IEnumerable<ReceitaViewModel>> GetLatestCookies();
    }
}
