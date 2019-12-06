using System;
using Xunit;

namespace C_Museum.test
{
    public class testRumExit
    {
        [Fact]
        // test av kopplingarna mellan rummen
        // kontrollera antalet utgångar per rum
        // testa också ändrad planlösning, se kommentarerna
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
    }
}