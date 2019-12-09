// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // skapar en lista över det rum man för närvarande befinner
    // sig i, och möjliga vägar att gå
    // hämtar information om de tavlor som hör till aktuellt rum
    public class cMuseum {
        // instansvariabler, ej åtkomstbara utifrån
        private List<cRum> rumLista = new List<cRum>();

        // constructor 
        // rumId "0" innebär utgång, ingen karta skapas
        // nuvarande position måste anges, läggs först i listan
        // listan fylls på med ev angränsande rum
        public cMuseum(string museum, string id) {
            if (id != "0") {
                cRum rum = new cRum(id);
                rumLista.Add(rum);
                GetOpenRooms(museum, id);
            }
        }

        // properties, läsbehörighet 
        public List<cRum> RumLista { 
            get { return rumLista; } 
        }  

        // hämta data om angränsande rum (öppen dörr)
        // olika planlösningar hämtas beroende på valt museum
        public void GetOpenRooms(string museum, string rumId) {
            // aktuell planritning hämtas
            string[,] kartBeskrivning = HemtaPlanritning(museum);

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
        
        // läs in planritning för valt museum
        private string[,] HemtaPlanritning(string museum) {
            // stora fotorundan
            if (museum == "1") {              
                return cFoto.kartBeskrivning;
            }

            // lilla fotorundan
            if (museum == "2") {                   
                return cFotoMini.kartBeskrivning;
            }

            // ingen planritning hittades
            return null;
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