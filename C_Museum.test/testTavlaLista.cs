using System;
using System.Collections.Generic;
using Xunit;

namespace C_Museum.test
{
    public class testTavlaLista
    {
        [Fact]
        public void AntalRader()
        {            
            // arrange - testdata 
            string[,] tavelBeskrivning = {
            {"Öga", "Närbild på öga", "Fotograf: Elin", "8" },
            {"Öga2", "Närbild på öga", "Fotograf: Elin", "8" },
            {"Skymningsljus", "Solnedgång på sommaren", "Fotograf: Karin", "5" }
            };
            

            // act - test-case
            int antRad = (tavelBeskrivning.Length / 4);
            //int antRad = tavelBeskrivning[0].Rank;

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(3,antRad);
            //Assert.Equal("Karin", tavelBeskrivning[1,1]);    
        }

        [Fact]
        // test av urval från arrayen
        // utdata är lista av tavlor
        public void ListaUrval()
        {
            
            // arrange - testdata 
            string[,] tavelBeskrivning = {
            {"Öga", "Närbild på öga", "Fotograf: Elin", "8" },
            {"Öga2", "Närbild på öga", "Fotograf: Elin", "8" },
            {"Skymningsljus", "Solnedgång på sommaren", "Fotograf: Karin", "5" }
            };
            

            // act - test-case
            List<cTavla> tavellista = new List<cTavla>();

            string rumId = "8";
            int antKol = 4;
            int antRad = (tavelBeskrivning.Length / antKol);
            for (int ind = 0 ; ind < antRad ; ind++) {
                if (tavelBeskrivning[ind,3] == rumId) {
                    string namn = tavelBeskrivning[ind,0];
                    string besk = tavelBeskrivning[ind,1];
                    string upphov = tavelBeskrivning[ind,2];
                    string plac = tavelBeskrivning[ind,3];
                    cTavla tavla = new cTavla(namn, besk, upphov, plac);
                    tavellista.Add(tavla);
                }
            }

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(0,tavellista.Count);
            Assert.Equal("ökarin", tavellista[0].Namn);

            //Assert.Equal(tavellista[0].Namn, tavellista[0].Placering);         
        }
    }
}