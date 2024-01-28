using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi_dekorater
{
    class Stew
    {
        IIngredient ingredient;
        public void MushroomBeefStew()
        {
            ingredient = new BaseIngredientDecorator(new Water(new Beef(new Mushrooms)));
            ingredient.AddIngredient();
        }

    }
}
