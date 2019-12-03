using System;
using Xunit;

namespace C_Museum.test
{
    public class testCKarta
    {
        [Fact]
        public void SkapaKarta()
        {
            // arrange - testdata 
            var testobj1 = new cKarta("3");
            var testobj2 = new cKarta("2");


            // act - test-case

            // skapa och returnera objekt av cKarta
            // beskrivning hämtas från cRad

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(3, testobj1.openRoom.Count);
            Assert.Equal("Gröna rummet", testobj1.openRoom[0].Beskrivning);
            Assert.Equal("Korridor", testobj1.openRoom[1].Beskrivning);
            Assert.Equal("Röda rummet", testobj1.openRoom[2].Beskrivning);
            Assert.Equal(testobj1, testobj2);
            // Assert.Equal("entre", testobj1.PositionBesk);
        }
    }
}
