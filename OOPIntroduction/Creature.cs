namespace OOPIntroduction
{
    abstract class Creature
    {
        public int Health;
        public int Damage;

        public abstract void Attack();
        public abstract void Defense();
        public abstract void Move();
        public abstract void Die();
       
    }

}
   



