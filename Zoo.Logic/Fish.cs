namespace Zoo.Logic
{
    /// <summary>
    /// Represents a fish, which is a type of animal.
    /// </summary>
    /// <remarks>
    /// This class inherits from the <see cref="Animal"/> class and provides
    /// a specific implementation for the <see cref="ToString"/> method.
    /// </remarks>
    public class Fish : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fish"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the fish.</param>
        public Fish(string name)
                    : base(name)
        {

        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that includes the base class's string representation followed by a message indicating
        /// the object's ability to remain underwater for a long time.
        /// </returns>
        public override string ToString()
        {
            return $"{base.ToString()}, ich kann lange unter Wasser sein";
        }

    }
}
