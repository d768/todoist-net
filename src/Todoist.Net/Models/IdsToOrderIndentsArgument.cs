using System.Collections.Generic;

using Newtonsoft.Json;

namespace Todoist.Net.Models
{
    internal class IdsToOrderIndentsArgument : ICommandArgument
    {
        public IdsToOrderIndentsArgument(IEnumerable<OrderIndentEntry> idsToOrderIndents)
        {
            IdsToOrderIndents = new Dictionary<ComplexId, IEnumerable<uint>>();
            foreach (var entry in idsToOrderIndents)
            {
                IdsToOrderIndents.Add(
                    new KeyValuePair<ComplexId, IEnumerable<uint>>(entry.Id, entry.ToArray()));
            }
        }

        [JsonProperty("ids_to_orders_indents")]
        public IDictionary<ComplexId, IEnumerable<uint>> IdsToOrderIndents { get; set; }
    }
}
