namespace class_work{


namespace dice
{

    public class Dice6
    {
        protected System.Random rand;
        public Dice6(){
            rand=new System.Random();
        }
        public int play(){
            return rand.Next(1,7);
        }
    }

}
}