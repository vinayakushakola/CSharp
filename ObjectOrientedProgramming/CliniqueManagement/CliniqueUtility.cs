using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using ConsoleTables;

namespace ObjectOrientedProgramming.CliniqueManagement
{
    class CliniqueUtility
    {
        public static Doctor CreateDoctor()
        {
            try
            {
                string name, specialization, availability;
                int doctorId;

                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Specialization: ");
                specialization = Console.ReadLine();
                Console.Write("Enter Availability Morning/Evening: ");
                availability = Console.ReadLine();
                //Creating DoctorID
                doctorId = CreateId();

                Doctor doctor = new Doctor()
                {
                    Name = name,
                    DoctorID = doctorId,
                    Specialization = specialization,
                    Availability = availability
                };
                return doctor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }
        public static Patient CreatePatient()
        {
            try
            {
                string name, mobileNumber;
                int patientId, age;

                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Mobile Number: ");
                mobileNumber = Console.ReadLine();
                Console.Write("Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                //Creating DoctorID
                patientId = CreateId();

                Patient patient = new Patient()
                {
                    Name = name,
                    PatientID = patientId,
                    Mobile = mobileNumber,
                    Age = age
                };
                return patient;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }
        public static Appointment BookAnAppointment()
        {
            try
            {
                int appointmentId = CreateAppointmentId();
                ShowDoctorList();
                ShowPatientList();
                Console.Write("Enter the Doctor Name: ");
                string doctorName = Console.ReadLine();
                Console.Write("Enter your Name: ");
                string patientName = Console.ReadLine();
                Console.Write("Enter the Date dd/mm/yyyy: ");
                string date = Console.ReadLine();

                PatientAppointment patientAppointment = new PatientAppointment()
                {
                    PatientName = patientName,
                    AppointmenID = appointmentId
                };
                List<PatientAppointment> patientList = new List<PatientAppointment>();
                patientList.Add(patientAppointment);

                Appointment appointment = new Appointment()
                {
                    DoctorName = doctorName,
                    AppointmentDateTime = date,
                    PatientAppointments = patientList

                };

                List<Appointment> appointmentList = new List<Appointment>();
                appointmentList.Add(appointment);

                return appointment;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return null;
            }
        }
        public static void SearchDoctor(List<Doctor> doctors)
        {
            try
            {
                int id;
                string name, specialization, availability;
                Doctor doctor;

                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1. Search by ID");
                    Console.WriteLine("2. Search by Name");
                    Console.WriteLine("3. Search by Specialization");
                    Console.WriteLine("4. Search by Availability");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Doctor ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            doctor = CliniqueManagementSearch.SearchDoctorByID(doctors, id);
                            if (doctors == null)
                                Console.WriteLine("No Data Present.");
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No.\tId\tName\t\tSpecialization\t\tAvailability");
                                Console.WriteLine(1 + "\t" + doctor.DoctorID + "\t" + doctor.Name + "\t" + doctor.Specialization + "\t\t\t" + doctor.Availability);
                                Console.WriteLine();

                            }
                            break;
                        case 2:
                            Console.Write("Enter Doctor Name: ");
                            name = Console.ReadLine();
                            doctor = CliniqueManagementSearch.SearchDoctorByName(doctors, name);
                            if (doctors == null)
                                Console.WriteLine("No Data Present.");
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No.\tId\tName\t\tSpecialization\t\tAvailability");
                                Console.WriteLine(1 + "\t" + doctor.DoctorID + "\t" + doctor.Name + "\t" + doctor.Specialization + "\t\t\t" + doctor.Availability);
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.Write("Enter Doctor Specialization: ");
                            specialization = Console.ReadLine();
                            doctor = CliniqueManagementSearch.SearchDoctorBySpecialization(doctors, specialization);
                            if (doctors == null)
                                Console.WriteLine("No Data Present.");
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No.\tId\tName\t\tSpecialization\t\tAvailability");
                                Console.WriteLine(1 + "\t" + doctor.DoctorID + "\t" + doctor.Name + "\t" + doctor.Specialization + "\t\t\t" + doctor.Availability);
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            Console.Write("Enter Doctor Availability: ");
                            availability = Console.ReadLine();
                            doctor = CliniqueManagementSearch.SearchDoctorByAvailability(doctors, availability);
                            if (doctors == null)
                                Console.WriteLine("No Data Present.");
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No.\tId\tName\t\tSpecialization\t\tAvailability");
                                Console.WriteLine(1 + "\t" + doctor.DoctorID + "\t" + doctor.Name + "\t" + doctor.Specialization + "\t\t\t" + doctor.Availability);
                                Console.WriteLine();
                            }
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }
        public static void SearchPatient(List<Patient> patients)
        {
            try
            {
                int id;
                string name, mobile;
                Patient patient;

                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1. Search by ID");
                    Console.WriteLine("2. Search by Name");
                    Console.WriteLine("3. Search by Mobile Number");
                    Console.WriteLine("4. Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Patient ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            patient = CliniqueManagementSearch.SearchPatientByID(patients, id);
                            if (patients == null)
                                Console.WriteLine("No Data Present.");
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No.\tId\tName\t\tMobile Number"); 
                                Console.WriteLine(1 + "\t" + patient.PatientID + "\t" + patient.Name + "\t" + patient.Mobile);
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            Console.Write("Enter Patient Name: ");
                            name = Console.ReadLine();
                            patient = CliniqueManagementSearch.SearchPatientByName(patients, name);
                            if (patients == null)
                                Console.WriteLine("No Data Present.");
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No.\tId\tName\t\tMobile Number");
                                Console.WriteLine(1 + "\t" + patient.PatientID + "\t" + patient.Name + "\t" + patient.Mobile);
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.Write("Enter Patient Mobile Number: ");
                            mobile = Console.ReadLine();
                            patient = CliniqueManagementSearch.SearchPatientByName(patients, mobile);
                            if (patients == null)
                                Console.WriteLine("No Data Present.");
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No.\tId\tName\t\tMobile Number");
                                Console.WriteLine(1 + "\t" + patient.PatientID + "\t" + patient.Name + "\t" + patient.Mobile);
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }



        public static void ShowDoctorList()
        {
            try
            {
                string path = CliniqueManagementProgram.DoctorPath;
                string readingFile = File.ReadAllText(path);
                var myData = JsonConvert.DeserializeObject<DoctorList>(readingFile);
                List<Doctor> doctorsInfo = myData.DoctorsInfo;

                int count;

                if (doctorsInfo.Count == 0)
                    Console.WriteLine("No Data Present");
                else
                {
                    count = 1;
                    ConsoleTable table = new ConsoleTable("No", "Name", "ID", "Specialization", "Availability");
                    foreach (Doctor doctor in doctorsInfo)
                    {
                        table.AddRow(count, doctor.Name, doctor.DoctorID, doctor.Specialization, doctor.Availability);
                        count++;
                    }
                    table.Options.EnableCount = false;
                    table.Write();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}+\n", ex.Message);
            }
        }
        public static void ShowPatientList()
        {
            try
            {
                string path = CliniqueManagementProgram.PatientPath;
                string readingFile = File.ReadAllText(path);
                var myData = JsonConvert.DeserializeObject<PatientList>(readingFile);
                List<Patient> patientsInfo = myData.PatientsInfo;

                int count;

                if (patientsInfo.Count == 0)
                    Console.WriteLine("No Data Present");
                else
                {
                    count = 1;
                    ConsoleTable table = new ConsoleTable("No", "ID", "Name", "Mobile", "Age");
                    foreach (Patient patient in patientsInfo)
                    {
                        table.AddRow(count, patient.PatientID, patient.Name, patient.Mobile, patient.Age);
                        count++;
                    }
                    table.Options.EnableCount = false;
                    table.Write();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}\n", ex.Message);
            }
        }


        public static void UpdateDoctorFile(List<Doctor> doctorInfo, string doctorPath)
        {
            try
            {
                DoctorList doctorList = new DoctorList()
                {
                    DoctorsInfo = doctorInfo
                };

                string doctorJsonData = JsonConvert.SerializeObject(doctorList);

                using StreamWriter sw = new StreamWriter(doctorPath);
                sw.WriteLine(doctorJsonData);
                Console.WriteLine("File saved Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}\n", ex.Message);
            }
        }
        public static void UpdatePatientFile(List<Patient> patientInfo, string patientPath)
        {
            try
            {
                PatientList patientList = new PatientList()
                {
                    PatientsInfo = patientInfo
                };

                string patientJsonData = JsonConvert.SerializeObject(patientList);

                using StreamWriter sw = new StreamWriter(patientPath);
                sw.WriteLine(patientJsonData);
                Console.WriteLine("File saved Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}\n", ex.Message);
            }
        }
        public static void UpdateAppointmentFile(List<Appointment> appointmentInfo, string appointmentPath)
        {
            try
            {
                AppointmentList appointmentList = new AppointmentList()
                {
                    Appointments = appointmentInfo
                };

                string appointmentJsonData = JsonConvert.SerializeObject(appointmentList);

                using StreamWriter sw = new StreamWriter(appointmentPath);
                sw.WriteLine(appointmentJsonData);
                Console.WriteLine("Appointment Booked Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}\n", ex.Message);
            }
        }



        public static int CreateId()
        {
            try
            {
                Random random = new Random();
                int UniqueId = random.Next(000000, 999999);
                return UniqueId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}\n", ex.Message);
                return 0;
            }
        }
        public static int CreateAppointmentId()
        {
            try
            {
                Random random = new Random();
                int UniqueId = random.Next(0000, 9999);
                return UniqueId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}\n", ex.Message);
                return 0;
            }
        }
        public static List<Doctor> ReadDoctorJsonFile()
        {
            try
            {
                string filename = CliniqueManagementProgram.DoctorPath;

                string doctorData = File.ReadAllText(filename);

                var DoctorObject = JsonConvert.DeserializeObject<DoctorList>(doctorData);

                List<Doctor> doctors;

                if (DoctorObject == null)
                    doctors = new List<Doctor>();
                else
                    doctors = DoctorObject.DoctorsInfo;

                return doctors;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }
        public static List<Patient> ReadPatientJsonFile()
        {
            try
            {
                string filename = CliniqueManagementProgram.PatientPath;

                string patientData = File.ReadAllText(filename);

                var PatientObject = JsonConvert.DeserializeObject<PatientList>(patientData);

                List<Patient> patients;

                if (PatientObject == null)
                    patients = new List<Patient>();
                else
                    patients = PatientObject.PatientsInfo;

                return patients;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }
    }
}
