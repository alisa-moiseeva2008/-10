using System;
using System.Collections.Generic;
public abstract class Department
{
    protected int departmentId;
    protected string name;
    protected Doctor headOfDepartment;
    protected List<Doctor> doctors;
    protected bool[] beds;

    public Department()
    {
        doctors = new List<Doctor>();
    }
    public Department(int departmentId) : this()
    {
        this.departmentId = departmentId;
    }
    public Department(int departmentId, string name) : this(departmentId)
    {
        this.name = name;
    }
    public Department(int departmentId, string name, int bedCount) : this(departmentId, name)
    {
        beds = new bool[bedCount];
        for (int i = 0; i < bedCount; i++)
        {
            beds[i] = true;
        }
    }
    public int DepartmentId { get { return departmentId; } }
    public string Name { get { return name; } set { name = value; } }
    public Doctor HeadOfDepartment { get { return headOfDepartment; } set { headOfDepartment = value; } }
    public List<Doctor> Doctors { get { return doctors; } set { doctors = value; } }
    public bool[] Beds { get { return beds; } set { beds = value; } }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
        NotifyDoctors($"Новый врач {doctor.FirstName} {doctor.LastName} добавлен в отделение");
    }
    public bool RemoveDoctor(int doctorId)
    {
        for (int i = 0; i < doctors.Count; i++)
        {
            if (doctors[i].DoctorId == doctorId)
            {
                doctors.RemoveAt(i);
                NotifyDoctors($"Врач с ID {doctorId} удален из отделения");
                return true;
            }
        }
        return false;
    }
    public Doctor FindDoctor(int doctorId)
    {
        foreach (Doctor doctor in doctors)
        {
            if (doctor.DoctorId == doctorId)
                return doctor;
        }
        return null;
    }
    public int GetAvailableBeds()
    {
        int count = 0;
        if (beds != null)
        {
            foreach (bool bed in beds)
                if (bed) count++;
        }
        return count;
    }
    protected void NotifyDoctors(string message)
    {
        foreach (Doctor doctor in doctors)
        {
            Console.WriteLine($"Уведомление для доктора {doctor.FirstName} {doctor.LastName} из отделения {name}: {message}");
        }
    }
    public void NotifyNewPatient(Patient patient)
    {
        NotifyDoctors($"Поступил новый пациент: {patient.LastName} {patient.FirstName}");
    }

    public void NotifyProtocolUpdate(string protocolName)
    {
        NotifyDoctors($"Обновлен протокол лечения: {protocolName}");
    }
    public void NotifyMeeting(DateTime meetingTime, string topic)
    {
        NotifyDoctors($"Собрание {meetingTime:dd.MM.yyyy HH:mm}: {topic}");
    }
}