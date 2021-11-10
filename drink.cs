using System;
using System.Collections.Generic;
using System.Text;

namespace laba_4
{
    public class Drink
    {
        double size = 2;
    }
    public class Juice: Drink
    {
        JuiceFruit fruit = JuiceFruit.apple;
        bool pulp = false;
    }
    public class Soda: Drink 
    {
        SodaType type = SodaType.CocaCola;
        int bubbles = 10000;
    }
    public class Alco: Drink
    {
        AlcoType type = AlcoType.Beer;
        double alcoPercent = 10;
    }
    public enum JuiceFruit { apple,orange,banana,tomato }
    public enum SodaType { CocaCola,Sprite,Fanta,Pepsi }
    public enum AlcoType { Beer,Vodka,Wine }
}
