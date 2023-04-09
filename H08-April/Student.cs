internal class Student
    {

    #region Fields

    public string Name;
    public string SurName;
    public string Group;
    public int Point;
    public bool IsGraduated;

    #endregion

    #region Methods

    public void GetFullName()
    {
        Console.WriteLine(Name + " " + SurName);
    }
    public void GetAllInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {SurName}");
        Console.WriteLine($"Group: {Group}");
        Console.WriteLine($"Point: {Point}");
        Console.WriteLine($"isGraduated: {IsGraduated}");
        if (IsGraduated) Console.WriteLine("This student has graduated.");
        else Console.WriteLine("Still learning...");
    }
    public void CheckPoint()
    {
        if (Point > 80) Console.WriteLine("You can proceed to the next exam.");
        else Console.WriteLine("You need to pass the previous exam.");
    }

    #endregion

    #region Constructors
    public Student():this("Someone", "Random")
    {

    }
    public Student(string name, string surname)
    {
        this.Name = name;
        this.SurName = surname;
    }
    public Student(string name, string surname, string group):this(name, surname)
    {
        this.Group = group;
    }
    public Student(string name, string surname, string group, int point, bool isGraduated):this(name, surname, group)
    {
        this.Point = point;
        this.IsGraduated = isGraduated;
    }
    #endregion

}
