class Student : Person
{
    private float averageScore;
    private string faculty;
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
    public override void Input()
    {
        base.Input();
        System.Console.WriteLine("Nhap diem TB: ");
        AverageScore = float.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Nhap khoa: ");
        Faculty = System.Console.ReadLine();
    }
    public override void Show()
    {
        base.Show();
        System.Console.WriteLine("Khoa: {0} | DiemTB: {1}",this.Faculty,this.AverageScore);
    }
    public override int Kind()
    {
        return 1;
    }
}
