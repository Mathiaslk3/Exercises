using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class OrangeTree
    {
        int age;
        int height;
        bool treeAlive;
        int numOranges;
        int orangesEaten;


        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return height;
        }
        public void SetTreeAlive (bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }
        public bool GetTreeAlive()
        {
            return treeAlive;
        }
        public int GetNumOranges()
        {
            return numOranges;
        }
        public int GetOrangesEaten()
        {
            return orangesEaten;
        }
        public void OneYearPasses()
        {
            age++;
            if (age >= 80)
            {
                treeAlive = false;
                numOranges = 0;
            }
            else
            {
                height = height + 2;
                treeAlive = true;
                orangesEaten = 0;
                if(age == 1)
                {
                    
                }
                else
                {
                    numOranges = age * 5 - 5;
                }
            }


        }
        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten = orangesEaten + count;
               
            }
            else
            {
                Console.WriteLine("Ikke nok abelsiner");
            }

            numOranges = numOranges - count;
        }

    }
}
