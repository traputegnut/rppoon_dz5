using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi_dekorater
{
    class Mushrooms: BaseIngredientDecorator
    {
        public Mushrooms(IIngredient ingredient) : base(ingredient)
        {
        }
        public override void AddIngredient()
        {
            base.AddIngredient();
            Console.WriteLine("add mushrooms");
        }
    }
}
