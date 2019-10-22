using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Receita.Api.Infrastructure;
using Receita.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Receita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly ReceitaContext _receitaContext;

        public ReceitaController(ReceitaContext context)
        {
            _receitaContext = context ?? throw new ArgumentNullException(nameof(context));

            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        [HttpGet]
        [ProducesResponseType(typeof(PaginatedItemsViewModel<Model.Receita>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<Model.Receita>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> ItemsAsyncEquipments([FromQuery]int pageSize = 10, [FromQuery]int pageIndex = 0, string ids = null)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = await GetItemsByIdsAsyncEquipments(ids);

                if (!items.Any())
                {
                    return BadRequest("Valor de ids incorretos. Deve ser uma lista de números separados por vírgula.");
                }

                return Ok(items);
            }

            var totalItems = await _receitaContext.Receitas
                .LongCountAsync();

            var itemsOnPage = await _receitaContext.Receitas
                .Include(categoria => categoria.Categoria)
                .OrderBy(c => c.Titulo)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToListAsync();

            var model = new PaginatedItemsViewModel<Model.Receita>(pageIndex, pageSize, totalItems, itemsOnPage);

            return Ok(model);
        }

        private async Task<List<Model.Receita>> GetItemsByIdsAsyncEquipments(string ids)
        {
            var numIds = ids.Split(',').Select(id => (Ok: int.TryParse(id, out int x), Value: x));

            if (!numIds.All(nid => nid.Ok))
            {
                return new List<Model.Receita>();
            }

            var idsToSelect = numIds
                .Select(id => id.Value);

            var items = await _receitaContext.Receitas.Where(ci => idsToSelect.Contains(ci.Id)).ToListAsync();

            return items;
        }
    }
}