using System;

namespace C_Museum
{
    public class Program
    {
        static void Main(string[] args)
        {
            // börjar med att visa information om programmet
            VisaProgramInfo();

            // start i entre-rummet
            string nyttRum = "1";

            // loop - vandra runt i rummen
            // loop tills utgången valts (rumId "0")
            bool fortsatt = true; 
            while (fortsatt) {
                // börja med blank skärm
                Console.Clear();

                // läs in info om nytt rum från kartan
                cKarta karta = new cKarta(nyttRum);

                // info om valt rum 
                VisaRumInfo(karta);   
                 
                // val av nytt rum, "0" = avslut 
                // continue = hoppar över resten av detta loop-varv            
                string nyttVal = HemtaNyttVal();
                if (nyttVal == "0") {
                    nyttRum = nyttVal;
                    fortsatt = false; 
                    continue;
                } 

                // nytt val kontrolleras
                // om ej giltigt, stanna kvar i samma rum
                // continue = hoppar över resten av detta loop-varv 
                // nuvarande rum är lagrat först i listan
                bool giltigtVal = karta.KontrolleraVal(nyttVal);
                if (!giltigtVal) {
                    nyttRum = karta.rumLista[0].RumId;
                    continue;
                }

                // hämta rumId för vald rad
                nyttRum = karta.GetNextRoom(nyttVal);
            }         
        }

        // Program-info visas vid program-start
        static private void VisaProgramInfo() {
            Console.WriteLine(" ");
            Console.WriteLine("Välkommen till fotomuseet.");
            Console.WriteLine("Här kan du vandra mellan olika rum och");
            Console.WriteLine("betrakta en mängd vackra foton.");
            Console.WriteLine("För varje rum får du information om var du befinner dig ");
            Console.WriteLine("och vilka rum som är öppna från det rummet.");
            Console.WriteLine("");
            Console.WriteLine("För varje rum kan du välja ett nytt att gå vidare till.");
            Console.WriteLine("Om du väljer ett rum som inte är öppet, ");
            Console.WriteLine("kommer du ingenstans.");
            Console.WriteLine("Ange [0] för att avsluta");
            Console.WriteLine("");
            Console.WriteLine("Tryck Enter för att starta.");
            string dummy = Console.ReadLine(); 
        }

        // utskrift av information om rummet
        static public void VisaRumInfo(cKarta karta) {
            Console.WriteLine(" ");
            Console.WriteLine("Välkommen till " + karta.rumLista[0].Beskrivning);
            Console.WriteLine("");

            // lista på möjliga val
            // nuvarande position finns i första raden (ind=1)
            Console.WriteLine("Gå vidare till: ");
            for (int ind = 1 ; ind < karta.rumLista.Count ; ind++) {
                Console.Write("val " + ind + ": ");
                Console.WriteLine(karta.rumLista[ind].Beskrivning);                
            } 
        }  

        static string HemtaNyttVal() {
            Console.WriteLine(" ");              
            Console.WriteLine("Vart vill du gå nu? ");
            Console.Write("Ange önskat nr [0] för att avsluta: ");
            string nyttVal = Console.ReadLine(); 
            return nyttVal;
        }  

    }
}
