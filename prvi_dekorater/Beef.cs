using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi_dekorater
{
    class Beef:BaseIngredientDecorator
    {
        IIngredient ingredient;
        public Beef(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }
        public virtual void AddIngredient()
        {
            ingredient.AddIngredient();
        }
    }
}
