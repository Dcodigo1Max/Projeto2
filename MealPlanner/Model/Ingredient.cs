using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Model
{


    public class Ingredients : IIngredient
    {
        public string Name;

        public string Type;

        public string EqualCheck()
        {
            if (Name == Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        



    }
}