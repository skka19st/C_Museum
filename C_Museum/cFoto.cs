// namespace som används
using System;
using System.Collections.Generic;

namespace C_Museum
{    
    // klass cFoto lagrar planlösningen för Fotomuseet
    static public class cFoto {
        // array som visar kopplingen mellan de olika rummen
        // visar: nuvarande rum, angränsande rum
        // static = klassvariabel, ej per skapat objekt
        static public string[,] kartBeskrivning = {
            {"1", "2"},  // Entre --> Korridor
            {"2", "1"},  // Korridor --> Entre
            {"2", "3"},  // Korridor --> Gröna rummet
            {"3", "2"},  // Gröna rummet --> Korridor
            {"3", "4"},  // Gröna rummet --> Röda rummet
            {"3", "6"},  // Gröna rummet --> Blåa rummet
            {"4", "3"},  // Röda rummet --> Gröna rummet
            {"4", "5"},  // Röda rummet --> Lila rummet
            {"5", "4"},  // Lila rummet --> Röda rummet
            {"5", "6"},  // Lila rummet --> Blåa rummet
            {"6", "5"},  // Blåa rummet --> Lila rummet
            {"6", "7"},  // Blåa rummet --> Svarta rummet
            {"6", "3"},  // Blåa rummet --> Gröna rummet
            {"6", "8"},  // Blåa rummet --> Vita rummet   
            {"7", "6"},  // Svarta rummet --> Blåa rummet
            {"8", "6"}   // Vita rummet --> Blåa rummet   
        };
    }
}