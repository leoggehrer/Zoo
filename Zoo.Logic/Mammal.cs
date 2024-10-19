namespace Zoo.Logic
{
    /// <summary>
    /// Represents a mammal, which is a type of animal that is characterized by being
    /// warm-blooded and having fur or hair, as well as the ability to nurse their young.
    /// </summary>
    /// <remarks>
    /// This class inherits from the <see cref="Animal"/> class and overrides the
    /// <see cref="ToString"/> method to provide additional information specific to mammals.
    /// </remarks>
    public class Mammal : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal"/> class.
        /// </summary>
        /// <param name="name">The name of the mammal.</param>
        public Mammal(string name)
                    : base(name)
        {

        }

        /// <summary>
        /// Returns a string that represents the current object, including the base class string representation
        /// and a custom message indicating that the object has been "suckled".
        /// </summary>
        /// <returns>
        /// A string that consists of the base class string representation followed by the message "ich wurde gesäugt".
        /// </returns>
        public override string ToString()
        {
            return $"{base.ToString()}, ich wurde gesäugt";
        }
    }
}
