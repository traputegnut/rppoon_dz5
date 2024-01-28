using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi_dekorater
{
    class BaseIngredientDecorator:IIngredient
    {
        IIngredient ingredient;
        public BaseIngredientDecorator(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }
        public virutal void AddIngredient()
        {
            ingredient.AddIngredient();
        }
    }
}
