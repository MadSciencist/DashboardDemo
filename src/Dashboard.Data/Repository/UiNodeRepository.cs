#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion
using Dashboard.Domain.Entities;
using Dashboard.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Data.Repository
{
    public class UiNodeRepository : IUiNodeRepository
    {
        private readonly EfContext _context;

        public UiNodeRepository(EfContext context)
        {
            _context = context;
        }

        public async Task<UiNode> AddNode(UiNode node)
        {
            var changeTracker = await _context.UiNodes.AddAsync(node);
            await _context.SaveChangesAsync();
            return changeTracker.Entity;
        }

        public async Task<IEnumerable<UiNode>> GetNodes()
        {
            var nodes =  await _context.UiNodes.ToListAsync();
            return nodes;
        }
    }
}
