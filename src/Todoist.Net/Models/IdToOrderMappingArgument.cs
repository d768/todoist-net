using System.Collections.Generic;

using Newtonsoft.Json;

namespace Todoist.Net.Models
{
    internal class IdToOrderMappingArgument : ICommandArgument
    {
        public IdToOrderMappingArgument(IEnumerable<OrderEntry> orderEntries)
        {
            Ids = new Dictionary<ComplexId, uint>();
            foreach (var entry in orderEntries)
            {
                Ids.Add(entry.Id, entry.Order);
            }
        }

        [JsonProperty("id_order_mapping")]
        public IDictionary<ComplexId, uint> Ids { get; set; }
    }
}
