using System;
using System.Collections.Generic;
public class Doctor
{
    private int doctorId;
    private string firstName;
    private string lastName;
    private string specialization;
    private List<Patient> patients;
    public Doctor()
    {
        patients = new List<Patient>();
    }
    public Doctor(int doctorId) : this()
    {
        this.doctorId = doctorId;
    }
    public Doctor(int doctorId, string firstName, string lastName) : this(doctorId)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public Doctor(int doctorId, string firstName, string lastName, string specialization) : this(doctorId, firstName, lastName)
    {
        this.specialization = specialization;
    }

    public int DoctorId { get { return doctorId; } }
    public string FirstName { get { return firstName; } set { firstName = value; } }
    public string LastName { get { return lastName; } set { lastName = value; } }
    public string Specialization { get { return specialization; } set { specialization = value; } }
    public List<Patient> Patients { get { return patients; } set { patients = value; } }

    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
        Console.WriteLine($"Пациент {patient.FirstName} {patient.LastName} добавлен к врачу {firstName} {lastName}");
    }

    public void AddPatient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
    {
        Patient newPatient = new Patient(patientId, firstName, lastName, dateOfBirth, diagnosis);
        patients.Add(newPatient);
        Console.WriteLine($"Пациент {firstName} {lastName} добавлен к врачу {this.firstName} {this.lastName}");
    }
    public bool RemovePatient(int patientId)
    {
        for (int i = 0; i < patients.Count; i++)
        {
            if (patients[i].PatientId == patientId)
            {
                patients.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
    public Patient FindPatient(int patientId)
    {
        foreach (Patient patient in patients)
        {
            if (patient.PatientId == patientId)
                return patient;
        }
        return null;
    }
    public int GetPatientCount()
    {
        return patients.Count;
    }
}
