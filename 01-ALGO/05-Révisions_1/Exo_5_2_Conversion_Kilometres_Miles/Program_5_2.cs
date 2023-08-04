using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace Exo_Conversion_Kilometres_Miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                /*else if (nombreSaisi > 0.01 || nombreSaisi < 1000000)
                {
                    do
                    {
                        Console.WriteLine("Veuillez entrer une valeur à convertir avec le sens de la conversion (km ou mi) ou 'q' pour quitter : ");
                        choixConversion = Console.ReadLine().ToLower();
                        testNombre = double.TryParse(choixConversion, out nombreSaisi);

                    } while (nombreSaisi < 0.01 && nombreSaisi > 1000000 || testNombre == false);
                }*/
                }


            }
                        
              
            //Console.WriteLine( " sortie plage");
                
            }
        }
    

                   
                
            

        


    

           

            
       

    












            
    


    

