using Interface__Static_members;

public class Student : ICodeAcademy
{
    public static int Count = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string CodeEmail { get; set; }

    public Student(string name, string surname)
    {
        Count++;
        Id = Count;
        Name = name;
        Surname = surname;
        GenerateEmail();
    }

    public void GenerateEmail()
    {
        CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
    }

    public void GetInfo()
    {
        Console.WriteLine($"ID: {Id}, Ad: {Name}, Soyad: {Surname}, Email: {CodeEmail}");
    }
}
