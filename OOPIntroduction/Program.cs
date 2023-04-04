using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Inheritance
            //Teacher tural = new Teacher
            //{
            //    Name = "Tural",
            //    LastName = "Aliyev",
            //    Phone = "213123213",
            //    Position = "Teacher"
            //};


            //Student student = new Student();

            //student.Name = "Adil";
            //student.LastName = "Adil";
            //student.Phone = "123123123213";
            //student.Group = "Tk84";


            //Goblin goblin = new Goblin();
            //goblin.Damage = 50;
            //Ogr ogr = new Ogr();
            //ogr.Damage = 200;
            //goblin.GoblinSkill.ToString();

            #endregion

            //Creature silvana = new Creature();  // cannot be created



            //LitchKing litch = new LitchKing();
            //litch.Attack();

            //Silvana silvana = new Silvana();
            //silvana.Attack();


            Creature[] creatures = new Creature[100];
            Creature crteature = new LitchKing();  // Upcast
            Creature creatureSilvana = new Silvana();

            creatures[0] = crteature;

            creatures[1] = creatureSilvana;

            LitchKing litch =  creatures[0] as LitchKing; // DownCast

            for (int i = 0; i < 2; i++)
            {
                creatures[i].Attack();
                //Spawn(creatures[0]);
            }






            //Silvana silvana = new Silvana();
            //LitchKing litch = new LitchKing();


            //Creature creature = litch; // (Creature) litch;

            //creature.Attack();

            //creature = silvana;
            //creature.Attack();





        }

        private static void Spawn(Creature creature)
        {
            throw new NotImplementedException();
        }
    }

}
   



