using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HospitalApp
{
    /// <summary>
    /// Class for managing the list of patients.
    /// </summary>
    public class Hospital
    {
        /// <summary>
        /// Gets or sets the list of all patients in the hospital.
        /// </summary>
        public List<Patient> Patients { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hospital"/> class and loads test data.
        /// </summary>
        public Hospital()
        {
            Patients = new List<Patient>();
            LoadTestData();
        }

        /// <summary>
        /// Loads test data into the patient list.
        /// </summary>
        public void LoadTestData()
        {
            Patients.Add(new Patient("Ivanov", 15, DateTime.Parse("2025-06-01"), Diagnosis.Influenza, 12));
            Patients.Add(new Patient("Petrov", 35, DateTime.Parse("2025-06-02"), Diagnosis.Influenza, 5));
            Patients.Add(new Patient("Sidorov", 28, DateTime.Parse("2025-06-03"), Diagnosis.Angina, 3));
            Patients.Add(new Patient("Dibrov", 43, DateTime.Parse("2025-06-04"), Diagnosis.Angina, 15));
            Patients.Add(new Patient("Smirnov", 22, DateTime.Parse("2025-06-05"), Diagnosis.Pneumonia, 7));
            Patients.Add(new Patient("Kuznetsov", 40, DateTime.Parse("2025-06-06"), Diagnosis.Pneumonia, 10));
        }

        /// <summary>
        /// Prints information about patients with the specified diagnosis.
        /// </summary>
        /// <param name="diagnosis">The diagnosis to filter patients by.</param>
        public void PrintPatientsByDiagnosis(Diagnosis diagnosis)
        {
            var filteredPatients = Patients.Where(p => p.Diagnosis == diagnosis)
                .OrderBy(p => p.Age)
                .ToList();

            if (filteredPatients.Count == 0)
            {
                Console.WriteLine($"\n{diagnosis}:");
                Console.WriteLine("No patients found.\n");
            }
            else
            {
                Console.WriteLine($"\n{diagnosis}:");
                Console.WriteLine("No | Last Name | Days in Hospital | Age");
                int count = 1;
                foreach (var patient in filteredPatients)
                {
                    Console.WriteLine($"{count} | {patient.LastName} | {patient.DaysInHospital} | {patient.Age}");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }

}