using System;
using Xunit;

namespace C_Museum.test
{
    public class testCRum
    {
        [Fact]
        public void KopplingIdBeskrivning()
        {
            // arrange - testdata 
            cRum testobj1 = new cRum("1");
            cRum testobj2 = new cRum("2");
            cRum testobj3 = new cRum("3");
            cRum testobj4 = new cRum("4");
            cRum testobj5 = new cRum("5");
            cRum testobj6 = new cRum("6");
            cRum testobj7 = new cRum("7");
            cRum testobj8 = new cRum("8");
            cRum testobj9 = new cRum("9");

            // act - test-case

            // koppling rumsid - rumsbeskrivning
            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal("1", testobj1.RumId);
            Assert.Equal("Entre", testobj1.Beskrivning);
            Assert.Equal("Korridor", testobj2.Beskrivning);
            Assert.Equal("Gröna rummet", testobj3.Beskrivning);
            Assert.Equal("Röda rummet", testobj4.Beskrivning);
            Assert.Equal("Lila rummet", testobj5.Beskrivning);
            Assert.Equal("Blåa rummet", testobj6.Beskrivning);
            Assert.Equal("Svarta rummet", testobj7.Beskrivning);
            Assert.Equal("Vita rummet", testobj8.Beskrivning);
            Assert.Equal("rumsbeskrivning saknas", testobj9.Beskrivning);
        }
    }
}
