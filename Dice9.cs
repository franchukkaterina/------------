namespace class_work{

namespace dice
{

    public sealed class Dice9 : dice.Dice6
    {
        public int play(){
            return rand.Next(1,10);
        }
    }
}
}