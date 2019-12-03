// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // klass cRum innehåller id för rum och rummets beskrivning
    public class cKarta {
        // array som visar kopplingen mellan de olika rummen
        // visar: nuvarande rum, angränsande rum
        // static = klassvariabel, ej per skapat objekt
         static private string[,] kartBeskrivning = {
            {"1", "2"},  // Entre --> Korridor
            {"2", "1"},  // Korridor --> Entre
            {"2", "3"},  // Korridor --> Gröna rummet
            {"3", "2"},  // Gröna rummet --> Korridor
            {"3", "4"},  // Gröna rummet --> Röda rummet
            {"6", "5"},  // Blåa rummet --> Lila rummet
            {"6", "7"},  // Blåa rummet --> Svarta rummet
            {"6", "8"},  // Blåa rummet --> Vita rummet
            {"6", "3"}   // Blåa rummet --> Gröna rummet 
        };

        public List<cRum> openRoom = new List<cRum>();

        // constructor 
        // nuvarande position måste anges, läggs först i listan
        // rumId "0" innebär utgång, ingen karta skapas
        // listan fylls på med ev angränsande rum
        public cKarta(string id) {
            if (id != "0") {
                cRum rum = new cRum(id);
                openRoom.Add(rum);
                GetOpenRooms();
            }

        }

        // hämta data om angränsande rum (möjlig förflyttning)
        private void GetOpenRooms() {
            // array-uppbyggnaden = [rad, kolumn]
            // antal rader i arrayen = antalet element / antal kolumner
            int antRad = (kartBeskrivning.Length / kartBeskrivning.Rank);            
            
            // ind = 1 (i första raden ligger nuvarande position) 
            string position = openRoom[0].RumId;
            for (int ind = 1 ; ind < antRad ; ind++) {
                // en ny rad i listan för varje möjlig förflyttning
                if (kartBeskrivning[ind,0] == position) {
                    cRum rum = new cRum(kartBeskrivning[ind,1]);
                    openRoom.Add(rum);                  
                }
            }
        }

        // kontrollerar om önskad förflyttning är tillåten
        // 
        static public bool GiltigtVal(string nyttRum) {
            // array-uppbyggnaden = [rad, kolumn]
            // antal rader i arrayen = antalet element / antal kolumner
            int antRad = (kartBeskrivning.Length / kartBeskrivning.Rank);            
            
            for (int ind = 0 ; ind < antRad ; ind++) {
                // en ny rad i listan för varje möjlig förflyttning
                if (kartBeskrivning[ind,1] == nyttRum) {
                    return true;                  
                }
            }
            // ingen träff = ej giltigt val
            return false;
        }
    }
}