using System;
using System.Collections.Generic;

namespace C_Museum
{
    public class Program
    {
        static void Main(string[] args)
        {
            // börjar med att visa information om programmet
            VisaProgramInfo();

            // används för att testa utgångsvillkor
            bool fortsatt = true;

            // start i entre-rummet
            string nyttRum = "1";

            // användaren väljer museum
            // enbart val '1' och '2' är tillåtna
            string museum = HemtaMuseum();
            if ((museum != "1") && (museum != "2")) {
                fortsatt = false; 
            }

            // loop - vandra runt i rummen
            // tills utgången valts (rumId "0") 
            while (fortsatt) {
                // visa nytt rum på blank skärm
                Console.Clear();

                // läs in info om valt rum och intilliggande rum
                // valt museum skickas med för att hitta rätt planritning
                cMuseum karta = new cMuseum(museum, nyttRum);

                // läs in info om ev tavlor i valt rum
                cTavelLista tavelLista = new cTavelLista(nyttRum);

                // visa info om valt rum och ev tavlor placerade i rummet
                VisaRumInfo(karta, tavelLista);   
                 
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
                    nyttRum = karta.RumLista[0].RumId;
                    continue;
                }

                // hämta rumId för vald rad
                nyttRum = karta.GetNextRoom(nyttVal);
            }         
        }

        // Program-info visas vid program-start
        static private void VisaProgramInfo() {
            Console.WriteLine(" ");
            Console.WriteLine("Välkommen till Fotomuseet!");
            Console.WriteLine("Här kan du välja mellan två olika turer.");
            Console.Write("På den stora turen ges du tillfälle att titta ");
            Console.WriteLine("in i samtliga rum. ");
            Console.Write("Den lilla turen går snabbare, men vissa dörrar ");
            Console.WriteLine("är stängda. ");
            Console.WriteLine("För varje rum kan du välja ett nytt att gå vidare till.");
            Console.WriteLine("Om du försöker välja ett rum som inte är öppet, ");
            Console.WriteLine("kommer du ingenstans.");
            Console.WriteLine("Ange [0] för att avsluta");
            Console.WriteLine("");
            Console.WriteLine("Tryck Enter för att starta.");
            string dummy = Console.ReadLine(); 
        }

        // utskrift av information om rummet
        // nuvarande position ligger lagrat på första raden i rumlistan
        static private void VisaRumInfo(cMuseum karta, cTavelLista lista) {
            // visa nuvarande position
            Console.WriteLine(" ");
            Console.WriteLine("Välkommen till " + karta.RumLista[0].Beskrivning);

            // lista alla tavlor som finns i rummet
            // vissa rum saknar tavlor
            if (lista.TavelLista.Count > 0) {
                Console.WriteLine("Här finns följande tavlor: ");
                Console.WriteLine("");
                for (int ind = 0 ; ind < lista.TavelLista.Count ; ind++) {
                    Console.Write(lista.TavelLista[ind].Namn);
                    Console.Write(", ");
                    Console.Write(lista.TavelLista[ind].Beskrivning);
                    Console.Write(", Fotograf: ");
                    Console.WriteLine(lista.TavelLista[ind].Upphov);              
                } 
            }

            // lista på möjliga val
            Console.WriteLine("");
            Console.WriteLine("Gå vidare till: ");
            for (int ind = 1 ; ind < karta.RumLista.Count ; ind++) {
                Console.Write("val " + ind + ": ");
                Console.WriteLine(karta.RumLista[ind].Beskrivning);                
            } 
        }  

        // läs in val av museum från skärmen
        static private string HemtaMuseum() {
            Console.WriteLine(" ");              
            Console.WriteLine("Vilken karta vill du se? ");
            Console.WriteLine("[1] stora turen - alla rum ");
            Console.WriteLine("[2] lilla turen - ett urval av rum");
            string nyttMuseum = Console.ReadLine(); 
            return nyttMuseum;
        }  

        // läs in nytt val från skärmen
        static private string HemtaNyttVal() {
            Console.WriteLine(" ");              
            Console.WriteLine("Vart vill du gå nu? ");
            Console.Write("Ange önskat nr [0] för att avsluta: ");
            string nyttVal = Console.ReadLine(); 
            return nyttVal;
        }  
    }
}
