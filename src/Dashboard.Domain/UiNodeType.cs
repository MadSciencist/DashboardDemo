#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion

using System.Runtime.Serialization;

namespace Dashboard.Domain
{
    /// <summary>
    /// Defines type of UI node.
    /// </summary>
    public enum UiNodeType
    {
        /// <summary>
        /// Config of whole page
        /// </summary>
        [EnumMember(Value = "pageScope")]
        PageScope = 1,

        /// <summary>
        /// Page member config
        /// </summary>
        [EnumMember(Value = "dashboardScope")]
        DashboardScope = 2
    }
}
