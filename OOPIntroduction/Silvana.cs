using System;

namespace OOPIntroduction
{
    class Silvana : Creature
    {
        public override void Attack()
        {
            Console.WriteLine("Silavana Attack Particle Start");
            Console.WriteLine("Silavana Attack Sound Play");
            Console.WriteLine("Silvana Attack Animation Start");


            Console.WriteLine("Instantiate Arrow");
            Console.WriteLine("Attack Finished");
            Console.WriteLine(new String('-',100));
        }

        public override void Defense()
        {
            Console.WriteLine("Silvana Defense");

        }

        public override void Move()
        {
            Console.WriteLine("Silvana Defense");

        }

        public override void Die()
        {
            Console.WriteLine("Silvana Defense");

        }


    }

}
   



