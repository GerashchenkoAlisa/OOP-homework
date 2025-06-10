using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HospitalApp
{
    /// <summary>
    /// Represents a patient in the hospital.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Gets or sets the last name of the patient.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the age of the patient.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the admission date of the patient.
        /// </summary>
        public DateTime AdmissionDate { get; set; }

        /// <summary>
        /// Gets or sets the diagnosis of the patient.
        /// </summary>
        public Diagnosis Diagnosis { get; set; }

        /// <summary>
        /// Gets or sets the number of days the patient has spent in the hospital.
        /// </summary>
        public int DaysInHospital { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class with the specified information.
        /// </summary>
        /// <param name="lastName">The last name of the patient.</param>
        /// <param name="age">The age of the patient.</param>
        /// <param name="admissionDate">The admission date of the patient.</param>
        /// <param name="diagnosis">The diagnosis of the patient.</param>
        /// <param name="daysInHospital">The number of days the patient has spent in the hospital.</param>
        public Patient(string lastName, int age, DateTime admissionDate, Diagnosis diagnosis, int daysInHospital)
        {
            LastName = lastName;
            Age = age;
            AdmissionDate = admissionDate;
            Diagnosis = diagnosis;
            DaysInHospital = daysInHospital;
        }
    }
}