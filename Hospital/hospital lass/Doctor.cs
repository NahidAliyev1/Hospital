using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.hospital_lass;

public class Doctor:PersonBase,IPerson
{
    public int Age { get; set; }
    public double ExperienceYear { get; set; }
    public Department DepartmentEnum { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Həkim: {Name} {Surname}\nYaş: {Age}\nTəcrübə ili\n{ExperienceYear}\nCins: {Gender}\nŞöbə: {DepartmentEnum}");
    }

    public string GetFullName()
    {
        return  $"{Name} {Surname}"; 
    }
}
