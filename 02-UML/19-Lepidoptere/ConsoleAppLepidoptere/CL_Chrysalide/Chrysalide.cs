using CL_Papillon;
using CL_Stade;

namespace CL_Chrysalide
{
    public class Chrysalide : Stade
    {
        public Chrysalide()
        {

        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne sais pas me déplacer !");
        }

        public override Stade SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}