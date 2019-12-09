using System;
using System.Collections.Generic;
using Xunit;

namespace C_Museum.test
{
    public class testcTavla
    {
        [Fact]
        public void testConstructor()
        {            
            // arrange - testdata 
            cTavla testobj1 = new cTavla("tavlans namn","beskrivning","karin","3");

            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal("tavlans namn",testobj1.Namn);
            Assert.Equal("beskrivning",testobj1.Beskrivning);
            Assert.Equal("karin",testobj1.Upphov);
        }

        [Fact]
        public void testConstructorLista()
        {            
            // arrange - testdata 
            cTavelLista testobj0 = new cTavelLista("3");

            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal("Vattenfall",testobj0.TavelLista[0].Namn);
            Assert.Equal("Helvetesfallet i Dalarna",testobj0.TavelLista[0].Beskrivning);
            Assert.Equal("Karin",testobj0.TavelLista[0].Upphov);
        }

        [Fact]
        // tavellistan ska innehålla samtliga tavlor placerade i angivet rum
        public void testListaPerRum()
        {            
            // arrange - testdata 
            cTavelLista testobj1 = new cTavelLista("1");
            cTavelLista testobj3 = new cTavelLista("3");
            cTavelLista testobj5 = new cTavelLista("5");
            cTavelLista testobj4 = new cTavelLista("4");
            cTavelLista testobj6 = new cTavelLista("6");
            cTavelLista testobj8 = new cTavelLista("8");

            // act - test-case

            // assert - säkerställa resultat
            // förväntat värde, faktiskt värde
            Assert.Equal(0,testobj1.TavelLista.Count);
            Assert.Equal(2,testobj3.TavelLista.Count);
            Assert.Equal(4,testobj5.TavelLista.Count);
            Assert.Equal(3,testobj4.TavelLista.Count);
            Assert.Equal(1,testobj6.TavelLista.Count);
            Assert.Equal(1,testobj8.TavelLista.Count);

            Assert.Equal("Vattenfall",testobj3.TavelLista[0].Namn);
            Assert.Equal("Utsikt",testobj3.TavelLista[1].Namn);
            Assert.Equal("Veteranbil",testobj4.TavelLista[0].Namn);
            Assert.Equal("Volvo",testobj4.TavelLista[1].Namn);
            Assert.Equal("Audi",testobj4.TavelLista[2].Namn);
            Assert.Equal("Nos",testobj5.TavelLista[0].Namn);
            Assert.Equal("Bakljus",testobj5.TavelLista[1].Namn);
            Assert.Equal("Öga",testobj5.TavelLista[2].Namn);
            Assert.Equal("Handtag",testobj5.TavelLista[3].Namn);
            Assert.Equal("Uppsala by night",testobj6.TavelLista[0].Namn);
            Assert.Equal("Långklänning",testobj8.TavelLista[0].Namn);
        }
    }
}