// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // klass cTavla innehåller info om tavlor
    // namn, beskrivning, upphovsmakare och rumsplacering
    public class cTavla {
        // instansvariabler, ej åtkomstbara utifrån
        private string namn;
        private string beskrivning;
        private string upphovsmakare;
        private string placering;

        // constructor
        // samtliga variabler skickas med vid anropet
        // skickar tillbaka en instans av klassen
        public cTavla(string namn, string besk, string upphov, string plac) {
            this.namn = namn;
            beskrivning = besk;
            upphovsmakare = upphov;
            placering = plac;
        } 
        
        // properties, läsbehörighet 
        public string Namn {
            get { return namn; }
        }
        public string Beskrivning {
            get { return beskrivning; }
        }
        public string Upphov {
            get { return upphovsmakare; }
        }
    }
}