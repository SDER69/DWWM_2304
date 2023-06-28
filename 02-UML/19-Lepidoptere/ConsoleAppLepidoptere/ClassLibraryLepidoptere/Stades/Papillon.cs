namespace ClassLibraryLepidoptere.Stades
{
    public class Papillon : Stade
    {
        public Papillon()
        {

        }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je me déplace en volant !");
        }

        public override Stade SeMetamorphoser()
        {
            return this;
        }
    }
}