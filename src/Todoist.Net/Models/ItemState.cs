namespace Todoist.Net.Models
{
    /// <summary>
    ///     Represents a state of a Todoist task.
    /// </summary>
    public class ItemState : OrderIndentEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemState" /> class.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="isChecked">The is checked.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="inHistory">The in history.</param>
        /// <param name="order">The order.</param>
        public ItemState(ComplexId itemId, bool isChecked, uint indent, bool inHistory, uint order)
            : base(itemId, order, indent)
        {
            IsChecked = isChecked;
            InHistory = inHistory;
        }

        /// <summary>
        ///     Gets a value indicating whether [in history].
        /// </summary>
        /// <value><c>true</c> if [in history]; otherwise, <c>false</c>.</value>
        public bool InHistory { get; }

        /// <summary>
        ///     Gets a value indicating whether this instance is checked.
        /// </summary>
        /// <value><c>true</c> if this instance is checked; otherwise, <c>false</c>.</value>
        public bool IsChecked { get; }

        internal override uint[] ToArray()
        {
            var array = new uint[4];

            array[0] = (uint) (InHistory ? 1 : 0);

            array[1] = (uint) (IsChecked ? 1 : 0);

            array[2] = Order;

            array[3] = Indent;

            return array;
        }
    }
}
