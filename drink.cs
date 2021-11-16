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
            String info = $"Объем: {size}";
            return info;
        }
        public virtual String getDrinkType() { return ""; }
        public static double randSize()
        {
            Random randSize = new Random();
            double size=(double)randSize.Next(1, 5)/2;
            return size;
        }
    }
    public class Juice: Drink
    {
        public JuiceFruit fruit = JuiceFruit.Яблочный;
        public bool pulp = false;

        public override String info()
        {
            String info = "";
            if (pulp)
            {
               info = $"Сок {fruit}\nС мякотью\n{base.info()}";
            }
            else
            {
               info = $"Сок {fruit}\nБез мякоти\n{base.info()}";

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

        public override String getDrinkType()
        {
            String type = $"{fruit} сок";
            return type;
        }
    }
    public class Soda: Drink 
    {
        public SodaType type = SodaType.CocaCola;
        public int bubbles = 10000;


        public override String info()
        {
            String info = "";
                info = $"Газировочка {type}\nКоличество пузырьков газа: {bubbles}\n{base.info()}";
            return info;
        }

        public static Soda Generate()
        {
            Random randType = new Random();
            int type = randType.Next(0, 4);
            Random randBubbles = new Random();
            int bubbles = randBubbles.Next(1000, 50000);
            return new Soda { type = (SodaType)type, bubbles=bubbles, size = randSize() };
        }

        public override String getDrinkType()
        {
            return type.ToString();
        }
    }


    public class Alco: Drink
    {
        public AlcoType type = AlcoType.Пиво;
        public double alcoPercent = 10;

        public override String info()
        {
            String info = "";
            info = $"{type}\nСодержание алкоголя: {alcoPercent}%\n{base.info()}";
            return info;
        }

        public static Alco Generate()
        {
            Random randType = new Random();
            int type = randType.Next(0, 3);
            Random randPercent = new Random();
            double percent = Math.Round((double)randPercent.Next(21, 300)/7,1);
            return new Alco { type = (AlcoType)type, alcoPercent = percent, size = randSize() };
        }

        public override String getDrinkType()
        {
            return type.ToString();
        }
    }
    public enum JuiceFruit { Яблочный,Апельсиновый,Банановый,Томатный }
    public enum SodaType { CocaCola,Sprite,Fanta,Pepsi }
    public enum AlcoType { Пиво,Водка,Вино }
}
