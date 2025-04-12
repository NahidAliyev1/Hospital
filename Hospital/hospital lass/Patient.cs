using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.hospital_lass;

public class Patient:PersonBase,IPerson
{
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Xəstə: {Name} {Surname}\nYaş: {Age}\nCins: {Gender}");
    }

    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }
}
