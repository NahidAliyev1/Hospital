using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.hospital_lass;

public class DBContext
{
    private static Patient[] patients = new Patient[0];
    private static Doctor[] doctors = new Doctor[0];
    private static Appointment[] appointments = new Appointment[0];

    public void AddNewPatient(Patient patient)
    {
        Array.Resize(ref patients, patients.Length + 1);
        patients[^1] = patient;
        HospitalStats.TotalPatientCount++;
    }
    public void AddNewDoctor(Doctor doctor)
    {
        Array.Resize(ref doctors, doctors.Length + 1);
        doctors[^1] = doctor;
        HospitalStats.TotalDoctorCount++;
    }
    public  void  AddNewAppointment(Appointment appointment)
    {
        Array.Resize(ref appointments, appointments.Length + 1);
        appointments[^1] = appointment;
        HospitalStats.TotalAppointmentCount++;
    }
    public Patient[] GetAllPatient()
    {
        return patients;
    }
    public Doctor[] GetAllDoctor()
    {
        return doctors;
    }
    public Appointment[] GetAllAppointment(){
        return appointments;
    }
}
