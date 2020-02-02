#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion

using Dashboard.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Domain.Repository
{
    public interface IUiNodeRepository
    {
        Task<IEnumerable<UiNode>> GetNodes();
        Task<UiNode> AddNode(UiNode node);
    }
}
