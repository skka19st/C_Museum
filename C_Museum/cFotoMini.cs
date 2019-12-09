// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // klass cFotoMini lagrar planlösningen för lilla foto-turen
    static public class cFotoMini {
        // array som visar kopplingen mellan de olika rummen
        // visar: nuvarande rum, angränsande rum
        // static = klassvariabel, ej per skapat objekt
        static public string[,] kartBeskrivning = {
            {"1", "3"},  // Entre --> Gröna rummet
            {"3", "1"},  // Gröna rummet --> Entre
            {"3", "4"},  // Gröna rummet --> Röda rummet
            {"3", "6"},  // Gröna rummet --> Blåa rummet
            {"4", "3"},  // Röda rummet --> Gröna rummet
            {"4", "5"},  // Röda rummet --> Lila rummet
            {"5", "4"},  // Lila rummet --> Röda rummet
            {"5", "6"},  // Lila rummet --> Blåa rummet
            {"6", "5"},  // Blåa rummet --> Lila rummet
            {"6", "3"},  // Blåa rummet --> Gröna rummet 
            {"4", "8"},  // Röda rummet --> Vita rummet     
            {"8", "4"}   // Vita rummet --> Röda rummet
        };
    }
}