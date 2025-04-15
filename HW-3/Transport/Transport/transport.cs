using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public abstract class Transport
    {
        /// <summary>
        /// Abstract method that describes the movement of the transport.
        /// </summary>
        public abstract void Move();
    }

    public class Car : Transport
    {
        /// <summary>
        /// Implements the movement of a car.
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("The car is driving on the road.");
        }
    }

    public class Boat : Transport
    {
        /// <summary>
        /// Implements the movement of a boat.
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("The boat is sailing on the water.");
        }
    }

    public class Airplane : Transport
    {
        /// <summary>
        /// Implements the movement of an airplane.
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("The airplane is flying in the sky.");
        }
    }
}