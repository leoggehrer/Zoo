using System.Text;

namespace Zoo.Logic
{
    /// <summary>
    /// Represents a collection of unique animals, allowing for set operations such as union, difference, and intersection.
    /// </summary>
    public class Set
    {
        #region Fields
        private Node? _head = null;
        #endregion Fields

        #region Properties
        /// <summary>
        /// Gets the number of nodes in the linked list.
        /// </summary>
        /// <value>
        /// The total count of nodes in the list. Returns 0 if the list is empty.
        /// </value>
        public int Count
        {
            get
            {
                int result = 0;
                Node? run = _head;

                while (run != null)
                {
                    result++;
                    run = run.Next;
                }
                return result;
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Adds an <see cref="Animal"/> to the set if it is not already present.
        /// </summary>
        /// <param name="animal">The <see cref="Animal"/> to be added to the set.</param>
        /// <remarks>
        /// This method checks if the specified animal is already in the set using the <see cref="IsAnimalInSet(Animal)"/> method.
        /// If the animal is not found in the set, a new <see cref="Node"/> is created with the animal and added to the head of the list.
        /// </remarks>
        public void Add(Animal animal)
        {
            if (IsAnimalInSet(animal) == false)
            {
                _head = new Node(animal, _head);
            }
        }
        /// <summary>
        /// Checks if a specified <see cref="Animal"/> is present in the set.
        /// </summary>
        /// <param name="animal">The <see cref="Animal"/> instance to search for in the set.</param>
        /// <returns>
        /// <c>true</c> if the animal is found in the set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAnimalInSet(Animal animal)
        {
            bool result = false;
            Node? run = _head;

            while (run != null && result == false)
            {
                if (run.Animal == animal)
                {
                    result = true;
                }
                run = run.Next;
            }
            return result;
        }
        #endregion Methods

        #region overrides
        /// <summary>
        /// Returns a string representation of the linked list, where each line contains the
        /// string representation of an animal in the list.
        /// </summary>
        /// <returns>A string that represents the animals in the linked list, with each animal
        /// on a new line.</returns>
        public override string ToString()
        {
            StringBuilder result = new();
            Node? run = _head;

            while (run != null)
            {
                result.AppendLine(run.Animal.ToString());
                run = run.Next;
            }
            return result.ToString();
        }
        #endregion overrides

        #region operators
        public static Set operator +(Set set1, Set set2)
        {
            Set result = new();
            Node? run = set1._head;

            while (run != null)
            {
                result.Add(run.Animal);
                run = run.Next;
            }
            run = set2._head;
            while (run != null)
            {
                result.Add(run.Animal);
                run = run.Next;
            }
            return result;
        }
        public static Set operator -(Set set1, Set set2)
        {
            Set result = new();
            Node? run = set1._head;

            while (run != null)
            {
                if (set2.IsAnimalInSet(run.Animal) == false)
                {
                    result.Add(run.Animal);
                }
                run = run.Next;
            }
            return result;
        }
        public static Set operator *(Set set1, Set set2)
        {
            Set result = new();
            Node? run = set1._head;

            while (run != null)
            {
                if (set2.IsAnimalInSet(run.Animal) == true)
                {
                    result.Add(run.Animal);
                }
                run = run.Next;
            }
            return result;
        }
        #endregion operators
    }
}
