#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Domain.Entities
{
    public class EntityBase<TKey> : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TKey Id { get; set; }
    }
}
