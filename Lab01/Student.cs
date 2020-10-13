class Student
{
    private string studentID;
    private string fullName;
    private float averageScore;
    private string faculty;
    //
    public string StudentID
    {
        get
        {
            return studentID;
        }
        set
        {
            studentID = value;
        }
    }
    //
    public string FullName
    {
        get
        {
            return fullName;
        }
        set
        {
            fullName = value;
        }
    }
    //
    public float AverageScore
    {
        get
        {
            return averageScore;
        }
        set
        {
            averageScore = value;
        }
    }
    //
    public string Faculty
    {
        get
        {
            return faculty;
        }
        set
        {
            faculty = value;
        }
    }
    //constructor
    public Student(){}
    public Student(string id,string fullName,float score, string faculty)
    {
        StudentID = id;
        FullName = fullName;
        AverageScore = score;
        Faculty = faculty;
    }
    //input output
    public void Input()
    {
        System.Console.WriteLine("Nhap MSSV: ");
        StudentID = System.Console.ReadLine();
        System.Console.WriteLine("Nhap ho ten sv: ");
        FullName = System.Console.ReadLine();
        System.Console.WriteLine("Nhap diem TB: ");
        AverageScore = float.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Nhap khoa: ");
        Faculty = System.Console.ReadLine();
    }
    public void Show()
    {
        System.Console.WriteLine("MSSV: {0} | Ho ten: {1} | Khoa: {2} | DiemTB: {3}",this.StudentID,this.FullName,this.Faculty,this.AverageScore);
    }

}
