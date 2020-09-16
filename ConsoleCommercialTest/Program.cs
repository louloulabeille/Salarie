using SalarieDII;
using System;
using System.Diagnostics;

namespace ConsoleCommercialTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /////// --- test de la classe Commercial qui hérite de salarie

            try
            {
                Commercial com = new Commercial("loulou", "labeille", "45HGF45");
                com.DateNaissance = new DateTime(1979, 4, 1);
                com.SalaireBrut = 1500m;
                com.TauxCS = 0.25m;
                com.ChiffreAffaire = 250000m;
                com.Commission = 0.01m;
                Debug.WriteLine(com.ToString());
                Debug.WriteLine("Salaire sans commission {0}",com.SalaireSansCommission);

                Salarie salCom = new Salarie("floflo", "florian", "19HGT12");
                salCom.DateNaissance = new DateTime(1991, 1, 1);
                salCom.SalaireBrut = 1600m;
                salCom.TauxCS = 0.25m;
                Commercial com2 = new Commercial(salCom);
                //Commercial com3 = new Commercial(com2);

                Debug.WriteLine(salCom.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
