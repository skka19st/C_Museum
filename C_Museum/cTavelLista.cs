// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // klass cTavellista innehåller en array med information
    // om samtliga tavlor, hårdkodat
    // namn, beskrivning, upphovsmakare och rumsplacering
    // skapar lista på tavlor som ska visas i det aktuella rummet
    public class cTavelLista {
        // static = klassvariabel, ej per skapat objekt
        static private int antKol = 4;

        // information om varje tavla
        static private string[,] tavelBeskrivning = {
            {"Vattenfall", "Helvetesfallet i Dalarna", "Karin", "3" },
            {"Utsikt", "Utsikt över Siljan", "Elin", "3" },
            {"Uppsala by night", "Uppsalas reklamskyltar", "Karin", "6" },
            {"Nos", "Närbild på marsvinsnos", "Elin", "5" },
            {"Bakljus", "Bromsljus på en bil", "Anton", "5" },
            {"Öga", "Närbild på öga", "Anton", "5" },
            {"Handtag", "Närbild på ett dörrhandtag", "Anton", "5" },
            {"Veteranbil", "Audi 100 Sedan, från -76", "PJ", "4" },
            {"Volvo", "Bil med kantiga former", "PJ", "4" },
            {"Långklänning", "Lämplig klädsel på slottets bal", "Elin", "8" },
            {"Audi", "En röd audi A6", "PJ", "4" }
        };

        // instansvariabler, ej åtkomstbara utifrån
        private List<cTavla> tavelLista = new List<cTavla>();

        // constructor
        // urval på placering 
        // skickar tillbaka en instans av klassen (en lista)
        public cTavelLista(string rumId) {
            SkapaTavelLista(rumId);
        }

        // properties, läsbehörighet 
        public List<cTavla> TavelLista { 
            get { return tavelLista; } 
        }  

        // skapar ett objekt av cTavla för varje tavla som hänger 
        // i angivet rum
        // returnerar lista på objekt av cTavla-klassen
        private List<cTavla> SkapaTavelLista(string rumId) {                
            // beräknar antal rader i arrayen
            // 'tavelBeskrivning.Length' = antal element i arrayen
            int antRad = (tavelBeskrivning.Length / antKol);
            
            // array-uppbyggnaden = [rad, kolumn]
            // för varje träff på rumId skapas en cTavla
            for (int ind = 0 ; ind < antRad ; ind++) {
                if (tavelBeskrivning[ind,3] == rumId) {
                    string namn = tavelBeskrivning[ind,0];
                    string besk = tavelBeskrivning[ind,1];
                    string upphov = tavelBeskrivning[ind,2];
                    string plac = tavelBeskrivning[ind,3];
                    cTavla tavla = new cTavla(namn, besk, upphov, plac);
                    tavelLista.Add(tavla);
                }
            }
            // returnerar lista med samtliga tavlor som hänger i rummet
            return tavelLista;
        } 
    }
}