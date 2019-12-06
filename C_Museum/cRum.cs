// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // klass cRum visar id för rum och rummets beskrivning
    public class cRum {
        // information om varje rum
        // static = klassvariabel, ej per skapat objekt
        static private string[,] rumsBeskrivning = {
            {"1", "Entre"},
            {"2", "Korridor"},
            {"3", "Gröna rummet"},
            {"4", "Röda rummet"},
            {"5", "Lila rummet"},
            {"6", "Blåa rummet"},            
            {"7", "Svarta rummet"},
            {"8", "Vita rummet"}
        };

        // attribut ej läsbara utanför klassen
        private string rumId;
        private string beskrivning;

        // constructor
        // rumsid måste anges, beskrivning ligger hårdkodat
        // skickar tillbaka en instans av klassen
        public cRum(string id) {
            this.rumId = id;
            this.beskrivning = GetBeskrivning(id);
        }

        // properties, läsbehörighet 
        public string RumId { 
            get { return rumId; } 
            set {  
                rumId = value; 
            } 
        }  
        public string Beskrivning { 
            get { return beskrivning; } 
        }  

        // returnerar rummets beskrivning  ??????
        // beskrivning ligger lagrat hårdkodat i en array 
        private string GetBeskrivning(string id) {                
            // beräknar antal rader i arrayen
            // antalet element i arrayen / antal kolumner
            int antRad = (rumsBeskrivning.Length / rumsBeskrivning.Rank);
            string text = "";
            
            // array-uppbyggnaden = [rad, kolumn]
            for (int ind = 0 ; ind < antRad ; ind++) {
                if (rumsBeskrivning[ind,0] == id) {
                    text = rumsBeskrivning[ind,1];
                    return text;
                }
            }

            if (text == "") {
                text = "rumsbeskrivning saknas";
            }

            // skicka tillbaka rumsbeskrivning
            return text;
        } 
    }
}