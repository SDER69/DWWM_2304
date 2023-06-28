using CL_Chrysalide;
using CL_Stade;

namespace CL_Chenille
{
    public class Chenille : Stade
    {
        public Chenille()
        {

        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je me déplace en rampant !");
        }

        public override Stade SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}