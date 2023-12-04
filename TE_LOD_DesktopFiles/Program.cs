/*   
 *      Dokumentacja pomocna do naszej dzisiejszej lekcji:
 *      https://learn.microsoft.com/pl-pl/dotnet/api/system.io?view=net-7.0
 */

using System;
using System.IO;    // Wymagana przestrzeń nazwy, by móc operować plikami

namespace TE_LOD_DesktopFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Obejmij kod obsługą błędów
            try
            {
                string path = "plik.txt";
                // Sprawdzenie czy plik istnieje
                if(File.Exists(path))
                {
                // Wyświetlenie całej zawartości tekstu
                Console.WriteLine(File.ReadAllText(path));
                }
                else
                {
                    Console.WriteLine("Nie ma tego pliku");
                    File.Create(path); // Tworzenie nowego pliku
                }
            } catch (IOException ex)
            {
                Console.WriteLine(ex.Message); // Napisz wiadomosc, gdy nie ma takiego pliku
            }

        }
    }
}

/* Pomoc do zajęć:
 *      - Klasa File, Directory, Path
 *      - Operacje na plikach (czy istnieje, odczyt, zapis, przenieś, usuń)
 *      - Operacje na katalogach (czy istnieje, stwórz, usuń, lista wszystkich plików oraz katalogów)
 *      - Operacje na strumieniach (StreamReader, StreamWriter)
 */