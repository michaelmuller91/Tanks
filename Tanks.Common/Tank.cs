using System;

namespace Tanks.Common
{
    /// <summary>
    /// Represents a single Tank in the Tank Game.
    /// </summary>
    public class Tank
    {
        /// <summary>
        /// Creates a new tank.
        /// </summary>
        /// <param name="name"></param>
        public Tank( string name )
        {
            this.Name = name;
            this.HealthPoints = 100;
            this.AttackPower = 10;
            this.DefensePower = 5;
            this.Alive = true;
        }

        /// <summary>
        /// The name of the tank.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The X-position of the tank on the grid.
        /// </summary>
        public int XCoordinate;

        /// <summary>
        /// The Y-position of the tank on the grid.
        /// </summary>
        public int YCoordinate;
        
        /// <summary>
        /// The amount of health that the tank currently has.
        /// </summary>
        public int HealthPoints { get; private set; }

        /// <summary>
        /// The amount of attack power that the tank currently has. 
        /// This will cause the health points of a defending tank to be reduced by this value - DefensePower.
        /// </summary>
        public int AttackPower;

        /// <summary>
        /// The amount of defense power that the tank currently has.
        /// This will reduce the amount of attack power of an attacking tank by this value.
        /// </summary>
        public int DefensePower;

        /// <summary>
        /// True if the tank is still alive.
        /// </summary>
        public bool Alive;

        /// <summary>
        /// Enables you to inflict damage against this tank if the amount of attack is
        /// greater than the tank's current amount of defense power.
        /// </summary>
        /// <param name="attackPower">The amount of damage to do to the tank</param>
        public void TakeDamage( int attackPower )
        {
            int damage = 0;

            // Check if we can defend against this amount of damage
            if ( attackPower > this.DefensePower )
            {
                // We are going to take *some* damage,
                // work out how much
                damage = attackPower - this.DefensePower;
            }

            // Decrement the amount of health this tank has by the amount of damage done
            this.HealthPoints = this.HealthPoints - damage;

            // Check if the tank died as a result of this
            if ( this.HealthPoints <= 0 )
            {
                // We died
                this.Alive = false;
                this.HealthPoints = 0;
            }
        }
    }
}
