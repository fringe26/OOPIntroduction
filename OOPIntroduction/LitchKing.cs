using System;

namespace OOPIntroduction
{
    class LitchKing : Creature
    {
        public override void Attack()
        {
            Console.WriteLine("Litch Attack");
            Console.WriteLine(new String('-', 100));
        }

        public override void Defense()
        {
            Console.WriteLine("Litch Defense");
        }

        public override void Die()
        {
            Console.WriteLine("Litch Die");
        }

        public override void Move()
        {
            Console.WriteLine("Litch Move");
        }
    }

}
   



