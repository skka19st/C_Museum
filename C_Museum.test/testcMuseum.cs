using System;
using Xunit;

namespace C_Museum.test
{
    public class testcMuseum
    {
        [Fact]
        // olika planlösningar
        // rumlistan ska ha angivet rum i första raden
        public void TestConstructor()
        {
            // arrange - testdata 
            cMuseum testobj1 = new cMuseum("1", "4");
            cMuseum testobj2 = new cMuseum("2", "4");

            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(3, testobj1.RumLista.Count);            
            Assert.Equal("Röda rummet", testobj1.RumLista[0].Beskrivning);
            Assert.Equal("Gröna rummet", testobj1.RumLista[1].Beskrivning);
            Assert.Equal("Lila rummet", testobj1.RumLista[2].Beskrivning);

            Assert.Equal(4, testobj2.RumLista.Count);
            Assert.Equal("Röda rummet", testobj2.RumLista[0].Beskrivning);
            Assert.Equal("Gröna rummet", testobj2.RumLista[1].Beskrivning);
            Assert.Equal("Lila rummet", testobj2.RumLista[2].Beskrivning);
            Assert.Equal("Vita rummet", testobj2.RumLista[3].Beskrivning);
        }

        [Fact]
        // planlösning för samtliga rum
        // alla intilliggande rum ska listas
        public void SkapaMuseumFoto()
        {
            // arrange - testdata 
            cMuseum testobj1 = new cMuseum("1", "1");
            cMuseum testobj2 = new cMuseum("1", "2");
            cMuseum testobj3 = new cMuseum("1", "3");
            cMuseum testobj4 = new cMuseum("1", "4");
            cMuseum testobj5 = new cMuseum("1", "5");
            cMuseum testobj6 = new cMuseum("1", "6");
            cMuseum testobj7 = new cMuseum("1", "7");
            cMuseum testobj8 = new cMuseum("1", "8");

            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(2, testobj1.RumLista.Count);
            Assert.Equal(3, testobj2.RumLista.Count);
            Assert.Equal(4, testobj3.RumLista.Count);
            Assert.Equal(3, testobj4.RumLista.Count);
            Assert.Equal(3, testobj5.RumLista.Count);
            Assert.Equal(5, testobj6.RumLista.Count);
            Assert.Equal(2, testobj7.RumLista.Count);
            Assert.Equal(2, testobj8.RumLista.Count);        
        }

        [Fact]
        // alternativ planlösning
        // alla intilliggande rum ska listas
        public void SkapaMuseumMini()
        {
            // arrange - testdata 
            cMuseum testobj1 = new cMuseum("2", "1");
            cMuseum testobj3 = new cMuseum("2", "3");
            cMuseum testobj4 = new cMuseum("2", "4");
            cMuseum testobj5 = new cMuseum("2", "5");
            cMuseum testobj6 = new cMuseum("2", "6");
            cMuseum testobj8 = new cMuseum("2", "8");

            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(2, testobj1.RumLista.Count);
            Assert.Equal(4, testobj3.RumLista.Count);
            Assert.Equal(4, testobj4.RumLista.Count);
            Assert.Equal(3, testobj5.RumLista.Count);
            Assert.Equal(3, testobj6.RumLista.Count);
            Assert.Equal(2, testobj8.RumLista.Count);        
        }
    }
}