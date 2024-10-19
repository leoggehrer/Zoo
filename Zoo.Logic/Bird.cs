namespace Zoo.Logic
{
    /// <summary>
    /// Represents a bird, which is a type of animal.
    /// </summary>
    /// <remarks>
    /// This class inherits from the <see cref="Animal"/> class and provides functionality
    /// specific to birds, including whether they can fly or not.
    /// </remarks>
    public class Bird : Animal
    {
        #region fields
        private readonly bool _cantFly = false;
        #endregion fields
        /// <summary>
        /// Initializes a new instance of the <see cref="Bird"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the bird.</param>
        public Bird(string name)
                    : base(name)
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bird"/> class.
        /// </summary>
        /// <param name="name">The name of the bird.</param>
        /// <param name="cantFly">A boolean value indicating whether the bird cannot fly.</param>
        public Bird(string name, bool cantFly)
                    : base(name)
        {
            _cantFly = cantFly;
        }

        /// <summary>
        /// Returns a string that represents the current object, including information about its flying capabilities.
        /// </summary>
        /// <returns>
        /// A string that describes the object. If the object can fly, it includes the message "ich kann große Strecken fliegen".
        /// If the object cannot fly, it includes the message "ich bin zwar ein Vogel kann aber nicht fliegen".
        /// </returns>
        public override string ToString()
        {
            string result = $"{base.ToString()}, ich kann große Strecken fliegen";

            if (_cantFly)
            {
                result = $"{base.ToString()}, ich bin zwar ein Vogel kann aber nicht fliegen";
            }
            return result;
        }

    }
}
