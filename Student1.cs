using System;

class Student
{
    private string name;
    private int age;
    private int course;
    private double rating;

    public Student(string name, int age, int course, double rating)
    {
        this.name = name;
        this.age = age;
        this.course = course;
        this.rating = rating;
    }

    public void EditStudent(string name, int age, double rating)
    {
        this.name = name;
        this.age = age;
        this.rating = rating;
    }

    public string GetRole(int course)
    {
        if (course <= 4)
            return "бакалавр";
        else
            return "магістр";
    }

    public void StudentRating()
    {
        if (rating >= 82)
            Console.WriteLine("Відмінно");
        else if (rating <= 60)
            Console.WriteLine("Перездача");
        else
            Console.WriteLine("Нормально");
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public int Course
    {
        get => course;
        set => course = value;
    }

    public double Rating
    {
        get => rating;
        set => rating = value;
    }
}