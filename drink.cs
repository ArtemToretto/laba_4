using System;
using System.Collections.Generic;
using System.Text;

namespace laba_4
{
    public class Drink
    {
       public double size = 2;
       public virtual String info()
        {
            String info = $"объем: {size}";
            return info;
        }
        public static double randSize()
        {
            Random randSize = new Random();
            double size=(double)randSize.Next(1, 5)/2;
            return size;
        }
    }
    public class Juice: Drink
    {
        public JuiceFruit fruit = JuiceFruit.apple;
        public bool pulp = false;

        public override String info()
        {
            String info = "";
            if (pulp)
            {
               info = $"Сок, со вкусом {fruit}, с мякотью, {base.info()}";
            }
            else
            {
               info = $"Сок, со вкусом {fruit}, без мякоти, {base.info()}";

            }
            return info;
        }

        public static Juice Generate()
        {
            Random randFruit = new Random();
            int fruit = randFruit.Next(0, 4);
            Random randPulp = new Random();
            bool pulp = randPulp.Next(0, 2) == 0;
            return new Juice { fruit = (JuiceFruit)fruit, pulp = pulp, size=randSize() };
        }
    }
    public class Soda: Drink 
    {
        public SodaType type = SodaType.CocaCola;
        public int bubbles = 10000;
    }
    public class Alco: Drink
    {
        public AlcoType type = AlcoType.Beer;
        public double alcoPercent = 10;
    }
    public enum JuiceFruit { apple,orange,banana,tomato }
    public enum SodaType { CocaCola,Sprite,Fanta,Pepsi }
    public enum AlcoType { Beer,Vodka,Wine }
}
