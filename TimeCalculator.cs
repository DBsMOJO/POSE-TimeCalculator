/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 11.11.2023
 *--------------------------------------------------------------
 * Description:
 * ...
 *--------------------------------------------------------------
*/

using System;

namespace TimeCalculator
{
    public class TimeCalculator
    {
        public static void Main()
        {
            int seconds,
                sec,
                min,
                hr,
                day;

            // Head
            Console.WriteLine("\nUmrechnung von Sekunden in Tage, Stunden, Minuten und Sekunden");
            Console.WriteLine("==============================================================");

            // Input
            Console.Write("\nGesamtsekunden [int]: ");
            seconds = Convert.ToInt32(Console.ReadLine());

            // Process
            sec = seconds % 60;
            min = seconds % (60 * 60) / 60;
            hr = seconds % (60 * 60 * 24) / (60 * 60);
            day = seconds / (60 * 60 * 24);

            // Output
            if (day != 0)
            {
                Console.WriteLine(
                    $"{seconds} Sekunden sind {day} Tage {hr} Stunden {min} Minuten und {sec} Sekunden"
                );
            }
            else
            {
                Console.WriteLine(
                    $"{seconds} Sekunden sind {hr} Stunden {min} Minuten und {sec} Sekunden"
                );
            }
            Console.WriteLine();
        }
    }
}
