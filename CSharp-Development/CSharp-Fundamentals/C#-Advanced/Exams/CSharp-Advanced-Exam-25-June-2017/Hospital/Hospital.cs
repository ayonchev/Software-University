using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Hospital
{
    public class PatientsDetails
    {
        public string DoctorName { get; set; }
        public string Department { get; set; }
        public int RoomNumber { get; set; }
    }
    class Hospital
    {
        static void Main()
        {
            Dictionary<string, PatientsDetails> patients = new Dictionary<string, PatientsDetails>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0] != "Output")
                {
                    string department = input[0];
                    string doctor = $"{input[1]} {input[2]}";
                    string patient = input[3];

                    if (!patients.ContainsKey(patient))
                    {
                        PatientsDetails currentPatientDetails = new PatientsDetails();
                        currentPatientDetails.DoctorName = doctor;
                        currentPatientDetails.Department = department;
                        currentPatientDetails.RoomNumber = (int)Math.Floor(patients.Where(x => x.Value.Department == department).Count() / 3.0);

                        currentPatientDetails.RoomNumber += 1;

                        patients.Add(patient, currentPatientDetails);
                    }
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                string criteria = Console.ReadLine().Trim();
                string doctorPattern = @"[A-Za-z]+\s[A-Za-z]+";
                string departmentAndRoomPattern = @"[A-Za-z]+\s[0-9]+";

                if (criteria != "End")
                {
                    if (Regex.IsMatch(criteria, doctorPattern))
                    {
                        foreach (var currentPatient in patients.Where(x => x.Value.DoctorName == criteria).OrderBy(x => x.Key))
                        {
                            Console.WriteLine(currentPatient.Key);
                        }
                    }
                    else if (Regex.IsMatch(criteria, departmentAndRoomPattern))
                    {
                        int currentRoom = int.Parse(criteria.Split(' ')[1]);
                        string currentDepartment = criteria.Split(' ')[0];

                        foreach (var currentPatient in patients.Where(x => x.Value.RoomNumber == currentRoom && x.Value.Department == currentDepartment).OrderBy(x => x.Key))
                        {
                            Console.WriteLine(currentPatient.Key);
                        }
                    }
                    else
                    {
                        foreach (var currentPatient in patients.Where(x => x.Value.Department == criteria))
                        {
                            Console.WriteLine(currentPatient.Key);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
