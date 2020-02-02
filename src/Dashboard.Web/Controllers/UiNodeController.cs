#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion
using Dashboard.Domain.Entities;
using Dashboard.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dashboard.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UiNodeController : ControllerBase
    {
        private readonly IUiNodeRepository _uiNodeRepository;

        public UiNodeController(IUiNodeRepository uiNodeRepository)
        {
            _uiNodeRepository = uiNodeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var nodes = await _uiNodeRepository.GetNodes();
            return Ok(nodes);
        }

        [HttpPost]
        public async Task<IActionResult> AddNode(UiNode node)
        {
            var createdNode = await _uiNodeRepository.AddNode(node);
            return CreatedAtAction(nameof(AddNode), createdNode);
        }
    }
}
