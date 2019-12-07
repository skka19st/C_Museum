// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // klass cKarta lagrar planlösningen (i en array)
    // skapar en lista över det rum man för närvarande befinner
    // sig i, och möjliga vägar att gå
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
            {"3", "6"},  // Gröna rummet --> Blåa rummet
            {"4", "3"},  // Röda rummet --> Gröna rummet
            {"4", "5"},  // Röda rummet --> Lila rummet
            {"5", "4"},  // Lila rummet --> Röda rummet
            {"5", "6"},  // Lila rummet --> Blåa rummet
            {"6", "5"},  // Blåa rummet --> Lila rummet
            {"6", "7"},  // Blåa rummet --> Svarta rummet
            {"6", "3"},  // Blåa rummet --> Gröna rummet
            {"6", "8"},  // Blåa rummet --> Vita rummet   kommentera bort vid test
            {"7", "6"},  // Svarta rummet --> Blåa rummet
            {"8", "6"}   // Vita rummet --> Blåa rummet   kommentera bort vid test

            // test för att flytta vita rummet till korridoren
            // kommentera bort motsvarande rader ovanför
            // {"2", "8"},  // Korridoren --> Vita rummet     
            // {"8", "2"},  // Vita rummet --> Korridoren
            // {"4", "8"},  // Röda rummet --> Vita rummet     
            // {"8", "4"}   // Vita rummet --> Röda rummet
        };

        // instansvariabler, ej åtkomstbara utifrån
        private List<cRum> rumLista = new List<cRum>();

        // constructor 
        // rumId "0" innebär utgång, ingen karta skapas
        // nuvarande position måste anges, läggs först i listan
        // listan fylls på med ev angränsande rum
        public cKarta(string id) {
            if (id != "0") {
                cRum rum = new cRum(id);
                rumLista.Add(rum);
                GetOpenRooms(id);
            }
        }

        // properties, läsbehörighet 
        public List<cRum> RumLista { 
            get { return rumLista; } 
        }  

        // hämta data om angränsande rum (öppen dörr)
        private void GetOpenRooms(string rumId) {
            // array-uppbyggnaden = [rad, kolumn]
            // antal rader i arrayen = antalet element / antal kolumner
            int antRad = (kartBeskrivning.Length / kartBeskrivning.Rank);  

            for (int ind = 0 ; ind < antRad ; ind++) {
                // en ny rad i listan för varje möjlig förflyttning
                if (kartBeskrivning[ind,0] == rumId) {
                    cRum rum = new cRum(kartBeskrivning[ind,1]);
                    rumLista.Add(rum);                  
                }
            }
        }

        // kontroll av val som användaren givit
        public bool KontrolleraVal(string valdRad) {
            // måste vara numeriskt
            // TryParse returnerar 'true' om värdet är numeriskt
            // 'valdRad' = ska kontrolleras, 'radnr' = resultatet
            // observera: villkoret är 'if not'
            int radnr;
            if (!(Int32.TryParse(valdRad, out radnr))) {
                return false;
            }

            // kolla valt radnr mot antal tillgängliga rum
            // ('||' är lika med'or')
            if ((radnr >= rumLista.Count) || (radnr < 1)) {
                return false;
            }

            // alla kontroller ok
            return true;
        } 

        // hämta rumId för den rad som användaren valt
        // TryParse returnerar 'true' om värdet är numeriskt
        // 'valdRad' = ska kontrolleras, 'radnr' = resultatet
        public string GetNextRoom(string valdRad) {
            int radnr;
            if (Int32.TryParse(valdRad, out radnr)){
                return rumLista[radnr].RumId;
            }

            // ingen träff - returnera id för nuvarande position
            return rumLista[0].RumId;
        }
    }
}