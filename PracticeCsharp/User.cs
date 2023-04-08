namespace PracticeCsharp;

public class User
{
    public string Name;
    public string Email;
    public string Password;
    public bool hasDriverLicense;
    public int Age;
    
    public User(string name, int age, bool hasDriverLicense, string email, string password)
    {
        Name = name;
        Age = age;
        this.hasDriverLicense = hasDriverLicense;
        Email = email;
        Password = password;
    }
    
    public User()
    {
       
    }

    public string Name1
    {
        get => Name;
        set => Name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Email1
    {
        get => Email;
        set => Email = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Password1
    {
        get => Password;
        set => Password = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool HasDriverLicense
    {
        get => hasDriverLicense;
        set => hasDriverLicense = value;
    }

    public int Age1
    {
        get => Age;
        set => Age = value;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Email: {Email}, Password: {Password}. Has driver license: {hasDriverLicense}. Age: {Age}";
    }
    
}