namespace Interfaces;

public interface IUser<T>
{
    T Id { get; set; }
}

class User<T> : IUser<T>
{
    public T Id { get; set; }
    public User(T id) => Id = id;
}

class IntUser : IUser<int>
{
    public int Id { get; set; }
    public IntUser(int id) => Id = id;
}

class NewPerson : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Company Work { get; set; }

    public NewPerson(string name, int age, Company company)
    {
        Name = name;
        Age = age;
        Work = company;
    }

    public object Clone()
    {
        // return MemberwiseClone(); Non-deeply cloning
        return new NewPerson(Name, Age, new Company(Work.Name)); // Deeply cloning
    }
}

class Company
{
    public string Name { get; set; }

    public Company(string name)
    {
        Name = name;
    }
}

class OldPerson : IComparable<OldPerson>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public OldPerson(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(OldPerson? person)
    {
        if (person is null) throw new ArgumentException("Incorrect argument type");
        return Age - person.Age;
    }
}

class PeopleComparer : IComparer<Human>
{
    public int Compare(Human? p1, Human? p2)
    {
        if (p1 is null || p2 is null)
            throw new ArgumentException("Incorrect argument type");
        return p1.Name.Length - p2.Name.Length;
    }
}

class Human
{
    public string Name { get;}
    public int Age { get; set; }
    public Human(string name, int age)
    {
        Name = name; Age = age;
    }
}