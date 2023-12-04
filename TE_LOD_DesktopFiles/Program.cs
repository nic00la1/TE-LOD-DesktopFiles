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
               // Console.WriteLine("Podaj ścieżkę do sprawdzenia: ");
               /* string path = Console.ReadLine();

                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
               */ 

                /* ============================================
                Sprawdzenie czy plik istnieje
                if (File.Exists(path))
                {
                    // Wyświetlenie całej zawartości tekstu
                    Console.WriteLine(File.ReadAllText(path));
                }
                else
                {
                    Console.WriteLine("Podaj zawartość do tego pliku");

                    // Zapisuje tresc uzytkownika do pliku
                    string data = Console.ReadLine();
                    File.WriteAllText(path, data);
                }
                */

                /* ============================================
                List<String> files = new List<String>();
                foreach (string dir in Directory.GetDirectories(path)) {
                    // Dodawanie do listy nazwy katalogu
                    files.Add(Path.GetDirectoryName(dir));
                }
                foreach (string file in Directory.GetFiles(path))
                {
                    files.Add(Path.GetFileName(file));
                }
                foreach (string element in files)
                {
                    // sprawdzenie czy plik ma rozszerzenie .txt
                    if(Path.GetExtension(element) == ".txt") {
                        Console.WriteLine("TEKST");
                    }
                    Console.WriteLine(element);
                } =============================================== */

                /* =======================================================
                Console.WriteLine("Jaki plik chcesz skopiowac?");
                string file = Console.ReadLine();
                Console.WriteLine("Do jakiego katalogu chcesz przeniesc ");
                string new_file = Console.ReadLine();

                string copied = Path.Combine(new_file, Path.GetFileName(file));
                // skopiuj plik


                // Przenoszenie pliku
                // File.Move(source, destination)
                File.Copy(file, copied);
                
                if (File.Exists(copied)) {
                    Console.WriteLine("skopiowano");
                } else
                {
                    Console.WriteLine("nie skopiowano");
                }
                ====================================================== */

                string path = "plik.txt";
                StreamReader reader = new StreamReader(path);

                string data = reader.ReadToEnd();
                Console.WriteLine(data);

                reader.Close();


            }
            catch (IOException ex)
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