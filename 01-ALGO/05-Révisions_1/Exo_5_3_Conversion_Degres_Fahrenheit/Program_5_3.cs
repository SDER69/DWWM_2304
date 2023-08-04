namespace Exo_5_3_Conversion_Degres_Fahrenheit
{
    internal class Program_5_3
    {
        static void Main(string[] args)
        {
            String nombreSaisi = "";
            double nombreExtrait = 0;

            double nombreSaisi = 0;
            string choixConversion;

            bool testNombre;





            testNombre = false;
            Console.WriteLine("Veuillez entrer une valeur à convertir avec le sens de la conversion (km ou mi) ou 'q' pour quitter : ");
            choixConversion = Console.ReadLine().ToLower();
            testNombre = double.TryParse(choixConversion, out nombreSaisi);

            string unite;
            // choixConversion = Console.ReadLine().ToLower();
            //  testNombre = double.TryParse(choixConversion, out nombreSaisi);

            if (testNombre == false)
            {

                if (choixConversion == "q")
                {
                    Console.WriteLine("Merci pour votre visite");
                    Environment.Exit(0);
                }
                else
                {
                    unite = choixConversion.Substring(choixConversion.Length - 2, 2);
                    string chaineValeur = choixConversion.Substring(0, choixConversion.Length - 2);
                    bool valeur = (double.TryParse(chaineValeur, out nombreSaisi));
                    if (nombreSaisi >= 0.01 && nombreSaisi <= 1000000)
                    {
                        if (unite == "km" && valeur == true)
                        {
                            double miles = nombreSaisi / 1.609;
                            miles = Math.Round(miles, 2);
                            Console.WriteLine(miles + " Miles");
                        }




                        else
                        {
                            double kms = nombreSaisi * 1.609;
                            kms = Math.Round(kms, 2);
                            Console.WriteLine(kms + " kms");
                        }
                    }
                }
            }
            else
            {

                if (nombreSaisi >= 0.01 && nombreSaisi <= 1000000)
                {
                    double miles = nombreSaisi / 1.609;
                    miles = Math.Round(miles, 2);
                    Console.WriteLine(miles + " Miles");
                }
            }













            /*do
            {
                Console.WriteLine("Veuillez entrer le nombre à convertir suivi de l'unité de température" +
                " (C pour Celsuis ou F pour Fahrenheit) séparé d'un espace : ");
                nombreSaisi = (Console.ReadLine());
                //nombreExtrait = Convert.ToDouble(nombreSaisi);
                if (nombreSaisi.TrimEnd(null).EndsWith("'F"))
                {
                    nombreExtrait = Double.Parse(nombreSaisi.Remove(nombreSaisi.LastIndexOf('\''), 2));
                }
                else if (nombreSaisi.TrimEnd(null).EndsWith("'C"))
                {
                    nombreExtrait = Double.Parse(nombreSaisi.Remove(nombreSaisi.LastIndexOf('\''), 2));
                    Console.WriteLine(nombreExtrait);
                }
            } while (nombreExtrait < -459.67 || nombreExtrait > 5000000);


            /*if (nombreSaisi.Length-1 == "C")
            {

            }
            else if (nombreSaisi.Length - 1 == "F")
            {


            }
            else if (nombreSaisi == "quit")
            {
                Console.WriteLine("Merci pour votre visite");
                Environment.Exit(0);
            }*/
        }
    }

}



            
   
    
 
