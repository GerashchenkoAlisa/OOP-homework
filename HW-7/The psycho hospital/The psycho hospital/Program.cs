using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HospitalApp
{

    /// <summary>
    /// Main class of the program.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            var diagnoses = Enum.GetValues(typeof(Diagnosis)).Cast<Diagnosis>().OrderBy(d => d.ToString()).ToList();

            Console.WriteLine("List of diagnoses:");
            for (int i = 0; i < diagnoses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {diagnoses[i]}");
            }

            Console.Write("\nSelect a diagnosis (number): ");
            if (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 1 && selectedIndex <= diagnoses.Count)
            {
                Diagnosis selectedDiagnosis = diagnoses[selectedIndex - 1];
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nSelected diagnosis: {selectedDiagnosis}");
                Console.ResetColor();
                hospital.PrintPatientsByDiagnosis(selectedDiagnosis);
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}