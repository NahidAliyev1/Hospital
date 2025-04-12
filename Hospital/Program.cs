using Hospital.hospital_lass;

class Program
{
    static void Main(string[] args)
    {

        
        DBContext context = new DBContext();
        
        while (true)
        {
            
            Console.WriteLine("\n--- Hospital Management ---");
            Console.WriteLine("1. Yeni xəstə əlavə et");
            Console.WriteLine("2. Yeni həkim əlavə et");
            Console.WriteLine("3. Həkimə xəstə təyin et");
            Console.WriteLine("4. Xəstələrin siyahısı");
            Console.WriteLine("5. Həkimlərin siyahısı");
            Console.WriteLine("6. Statistikaya bax");
            Console.WriteLine("7. Çıxış");
            Console.Write("Seçim: ");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Patient patient = new Patient();
                        Console.Write("Ad: "); patient.Name = Console.ReadLine();
                        Console.Write("Soyad: "); patient.Surname = Console.ReadLine();
                        Console.Write("Yaş: "); patient.Age = int.Parse(Console.ReadLine());
                        Console.Write("Gender (0-Male, 1-Female, 2-AttackHelicopter): ");
                        patient.Gender = (Gender)int.Parse(Console.ReadLine());
                        patient.Id = HospitalStats.TotalPatientCount + 1;
                        context.AddNewPatient(patient);
                        break;

                    case "2":
                        Doctor doctor = new Doctor();
                        Console.Write("Ad: "); doctor.Name = Console.ReadLine();
                        Console.Write("Soyad: "); doctor.Surname = Console.ReadLine();
                        Console.Write("Yaş: "); doctor.Age = int.Parse(Console.ReadLine());
                        Console.Write("Təcrübə ili: "); doctor.ExperienceYear = double.Parse(Console.ReadLine());
                        Console.Write("Gender (0-Male, 1-Female, 2-AttackHelicopter): ");
                        doctor.Gender = (Gender)int.Parse(Console.ReadLine());
                        Console.Write("Department (0-Terapiya, 1-Cərrahiyyə, 2-Pediatriya, 3-Kardiologiya): ");
                        doctor.DepartmentEnum = (Department)int.Parse(Console.ReadLine());
                        doctor.Id = HospitalStats.TotalDoctorCount + 1;
                        context.AddNewDoctor(doctor);
                        break;

                    case "3":
                        Console.Write("Xəstə ID: ");
                        int patientId = int.Parse(Console.ReadLine());
                        Console.Write("Həkim ID: ");
                        int doctorId = int.Parse(Console.ReadLine());

                        Appointment appointment = new Appointment
                        {
                            PatientId = patientId,
                            DoctorId = doctorId
                        };
                        context.AddNewAppointment(appointment);
                        Console.WriteLine("Təyinat uğurla əlavə olundu.");
                        break;

                    case "4":
                        foreach (var p in context.GetAllPatient())
                        {
                            p.DisplayInfo();
                        }
                        break;

                    case "5":
                        foreach (var d in context.GetAllDoctor())
                        {
                            d.DisplayInfo();
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Xəstələrin sayı: {HospitalStats.TotalPatientCount}");
                        Console.WriteLine($"Həkimlərin sayı: {HospitalStats.TotalDoctorCount}");
                        Console.WriteLine($"Təyinatların sayı: {HospitalStats.TotalAppointmentCount}");
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Yanlış seçim.Zəhmət olmasa düzgün seçim edin");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xəta baş verdi: {ex.Message}");
            }
        }
    }
}

