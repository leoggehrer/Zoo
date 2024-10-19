namespace Zoo.Logic
{
    /// <summary>
    /// Represents an abstract base class for animals.
    /// </summary>
    /// <remarks>
    /// This class provides a property for the name of the animal and a method to return a string representation of the animal.
    /// </remarks>
    public abstract class Animal
    {
        #region fields
        private string _name = string.Empty;
        #endregion fields

        #region properties
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// A string representing the name. The value can be set to any valid string.
        /// </value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        #endregion propeties

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        protected Animal(string name)
        {
            Name = name;
        }

        #region overrides
        /// <summary>
        /// Returns a string representation of the current object.
        /// </summary>
        /// <returns>A string that contains the name of the object.</returns>
        override public string ToString()
        {
            return $"Name: {Name}";
        }
        #endregion overrides
    }
}
