#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion

namespace Dashboard.Domain.Entities
{
    public class UiNode : EntityBase<int>
    {
        public int ParentId { get; set; }
        public UiNodeType Type { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
    }
}
