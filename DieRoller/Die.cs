using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die(1-6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Creates the die and rolls it 
        /// to start with a random number.
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// current face up value (What was rolled)
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if die is currently held
        /// </summary>
        public bool IsHeld { get; set; }
        
        

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/>
        /// to the new number. Returns new number
        /// </summary>
        public byte Roll()
        {
            // Generate random number
            Random random = new Random();
            byte newValue = (byte)random.Next(1, 7);

            // Set to face value
            FaceValue = newValue;

            // Return new number
            return FaceValue;

            
        }
    }
}
