using System;
using Xunit;

namespace C_Museum.test
{
    public class testCKarta
    {
        [Fact]
        // test av kopplingarna mellan rummen
        // kontrollera antalet utgångar per rum
        public void AntalExitPerRum()
        {
            // arrange - testdata 
            cKarta testobj1 = new cKarta("1");
            cKarta testobj2 = new cKarta("2");
            cKarta testobj3 = new cKarta("3");
            cKarta testobj4 = new cKarta("4");
            cKarta testobj5 = new cKarta("5");
            cKarta testobj6 = new cKarta("6");
            cKarta testobj7 = new cKarta("7");
            cKarta testobj8 = new cKarta("8");


            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(2, testobj1.rumLista.Count);
            Assert.Equal(4, testobj3.rumLista.Count);
            Assert.Equal(3, testobj5.rumLista.Count);
            Assert.Equal(2, testobj7.rumLista.Count);


            // kommentera vid test av alternativ planlösning
            Assert.Equal(3, testobj2.rumLista.Count); 
            Assert.Equal(3, testobj4.rumLista.Count); 
            Assert.Equal(5, testobj6.rumLista.Count); 
            Assert.Equal(2, testobj8.rumLista.Count);

            // avkommentera vid test av alternativ planlösning
            // Assert.Equal(4, testobj2.rumLista.Count);  
            // Assert.Equal(4, testobj4.rumLista.Count); 
            // Assert.Equal(4, testobj6.rumLista.Count); 
            // Assert.Equal(3, testobj8.rumLista.Count);
        }

        [Fact]
        // test av kopplingarna mellan rummen
        // för varje valt rum ska alla utgångar visas
        public void Kartkontroll()
        {
            // arrange - testdata 
            cKarta testobj1 = new cKarta("1");
            cKarta testobj2 = new cKarta("2");
            cKarta testobj3 = new cKarta("3");
            cKarta testobj4 = new cKarta("4");
            cKarta testobj5 = new cKarta("5");
            cKarta testobj6 = new cKarta("6");
            cKarta testobj7 = new cKarta("7");
            cKarta testobj8 = new cKarta("8");


            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde

            //Assert.Equal(testobj1, testobj2);
            Assert.Equal("Entre", testobj1.rumLista[0].Beskrivning);
            Assert.Equal("Korridor", testobj1.rumLista[1].Beskrivning);

            Assert.Equal("Korridor", testobj2.rumLista[0].Beskrivning);
            Assert.Equal("Entre", testobj2.rumLista[1].Beskrivning);
            Assert.Equal("Gröna rummet", testobj2.rumLista[2].Beskrivning);

            Assert.Equal("Gröna rummet", testobj3.rumLista[0].Beskrivning);
            Assert.Equal("Korridor", testobj3.rumLista[1].Beskrivning);
            Assert.Equal("Röda rummet", testobj3.rumLista[2].Beskrivning);
            Assert.Equal("Blåa rummet", testobj3.rumLista[3].Beskrivning);

            Assert.Equal("Röda rummet", testobj4.rumLista[0].Beskrivning);
            Assert.Equal("Gröna rummet", testobj4.rumLista[1].Beskrivning);
            Assert.Equal("Lila rummet", testobj4.rumLista[2].Beskrivning);

            Assert.Equal("Lila rummet", testobj5.rumLista[0].Beskrivning);
            Assert.Equal("Röda rummet", testobj5.rumLista[1].Beskrivning);
            Assert.Equal("Blåa rummet", testobj5.rumLista[2].Beskrivning);

            Assert.Equal("Blåa rummet", testobj6.rumLista[0].Beskrivning);
            Assert.Equal("Lila rummet", testobj6.rumLista[1].Beskrivning);
            Assert.Equal("Svarta rummet", testobj6.rumLista[2].Beskrivning);

            Assert.Equal("Gröna rummet", testobj6.rumLista[3].Beskrivning);

            Assert.Equal("Svarta rummet", testobj7.rumLista[0].Beskrivning);
            Assert.Equal("Blåa rummet", testobj7.rumLista[1].Beskrivning);

            Assert.Equal("Vita rummet", testobj8.rumLista[0].Beskrivning);

            // kommentera vid test av alternativ planlösning
            Assert.Equal("Vita rummet", testobj6.rumLista[4].Beskrivning);
            Assert.Equal("Blåa rummet", testobj8.rumLista[1].Beskrivning); 

            // avkommentera vid test av alternativ planlösning
            // Assert.Equal("Vita rummet", testobj2.rumLista[3].Beskrivning);
            // Assert.Equal("Vita rummet", testobj4.rumLista[3].Beskrivning);
            // Assert.Equal("Korridor", testobj8.rumLista[1].Beskrivning);
            // Assert.Equal("Röda rummet", testobj8.rumLista[2].Beskrivning);            
        }
    }
}
