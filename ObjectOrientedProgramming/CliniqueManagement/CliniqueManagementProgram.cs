using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.CliniqueManagement
{
    class CliniqueManagementProgram
    {
        public static string DoctorPath = @"D:/Github/CSharp/ObjectOrientedProgramming/CliniqueManagement/Data/DoctorsInformation.json";
        public static string PatientPath = @"D:/Github/CSharp/ObjectOrientedProgramming/CliniqueManagement/Data/PatientInformation.json";
        public static string AppointmentPath = @"D:/Github/CSharp/ObjectOrientedProgramming/CliniqueManagement/Data/AppointmentInformation.json";
        public static void CliniqueManagement()
        {
            try
            {
                List<Doctor> doctors = new List<Doctor>();
                List<Patient> patients = new List<Patient>();
                List<Appointment> appointments = new List<Appointment>();

                Doctor doctor;
                Patient patient;
                Appointment appointment;

                bool flag = true;
                while (flag)
                {
                    int choice;
                    Console.WriteLine("\n-----------------Clinique Management-----------------\n");
                    Console.WriteLine("1. Create Doctor");
                    Console.WriteLine("2. Create Patient");
                    Console.WriteLine("3. Show Doctors Data");
                    Console.WriteLine("4. Show Patients Data");
                    Console.WriteLine("5. Search Doctor");
                    Console.WriteLine("6. Search Patient");
                    Console.WriteLine("7. Book An Apointment");
                    Console.WriteLine("8. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Date: {0}", DateTime.Today.ToString("dd/MM/yyyy"));
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            doctor = CliniqueUtility.CreateDoctor();
                            doctors.Add(doctor);
                            CliniqueUtility.UpdateDoctorFile(doctors, DoctorPath);
                            Console.WriteLine();
                            break;
                        case 2:
                            patient = CliniqueUtility.CreatePatient();
                            patients.Add(patient);
                            CliniqueUtility.UpdatePatientFile(patients, PatientPath);
                            Console.WriteLine();
                            break;
                        case 3:
                            CliniqueUtility.ShowDoctorList();
                            Console.WriteLine();
                            break;
                        case 4:
                            CliniqueUtility.ShowPatientList();
                            Console.WriteLine();
                            break;
                        case 5:
                            doctors = CliniqueUtility.ReadDoctorJsonFile();
                            CliniqueUtility.SearchDoctor(doctors);
                            Console.WriteLine();
                            break;
                        case 6:
                            patients = CliniqueUtility.ReadPatientJsonFile();
                            CliniqueUtility.SearchPatient(patients);
                            Console.WriteLine();
                            break;
                        case 7:
                            appointment = CliniqueUtility.BookAnAppointment();
                            appointments.Add(appointment);
                            CliniqueUtility.UpdateAppointmentFile(appointments, AppointmentPath);
                            Console.WriteLine();
                            break;
                        case 8:
                            flag = false;
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}