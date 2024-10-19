namespace Zoo.Logic
{
    /// <summary>
    /// Represents a node in a linked list that holds an <see cref="Animal"/> object and a reference to the next node.
    /// </summary>
    /// <remarks>
    /// This class is intended for internal use and is part of a linked list structure for managing <see cref="Animal"/> instances.
    /// </remarks>
    internal class Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="animal">The <see cref="Animal"/> associated with the node.</param>
        /// <param name="next">The next <see cref="Node"/> in the linked list, or <c>null</c> if there is no next node.</param>
        public Node(Animal animal, Node? next)
        {
            Animal = animal;
            Next = next;
        }
        /// <summary>
        /// Gets or sets the <see cref="Animal"/> associated with this instance.
        /// </summary>
        /// <value>
        /// The <see cref="Animal"/> object that represents the animal.
        /// </value>
        public Animal Animal { get; set; }
        /// <summary>
        /// Gets or sets the next node in the linked list.
        /// </summary>
        /// <value>
        /// The next <see cref="Node"/> in the list, or <c>null</c> if there is no next node.
        /// </value>
        public Node? Next { get; set; }
    }
}
