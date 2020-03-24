using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming.CliniqueManagement
{
    class CliniqueManagementSearch
    {
        public static Doctor SearchDoctorByName(List<Doctor> doctors, string Name)
        {
            try
            {
                Doctor doctor = doctors.Find(x => x.Name == Name);
                return doctor;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static Doctor SearchDoctorByID(List<Doctor> doctors, int ID)
        {
            try
            {
                Doctor doctor = doctors.Find(x => x.DoctorID == ID);
                return doctor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static Doctor SearchDoctorBySpecialization(List<Doctor> doctors, string Specialization)
        {
            try
            {
                Doctor doctor = doctors.Find(x => x.Specialization == Specialization);
                return doctor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static Doctor SearchDoctorByAvailability(List<Doctor> doctors, string Availability)
        {
            try
            {
                Doctor doctor = doctors.Find(x => x.Availability == Availability);
                return doctor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public static Patient SearchPatientByName(List<Patient> patients, string Name)
        {
            try
            {
                Patient patient = patients.Find(x => x.Name == Name);
                return patient;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static Patient SearchPatientByID(List<Patient> patients, int ID)
        {
            try
            {
                Patient patient = patients.Find(x => x.PatientID == ID);
                return patient;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static Patient SearchPatientByMobilenumber(List<Patient> patients, string Mobile)
        {
            try
            {
                Patient patient = patients.Find(x => x.Mobile == Mobile);
                return patient;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
