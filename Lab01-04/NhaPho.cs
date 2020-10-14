class NhaPho : DiaOcD
{
    private int nam;
    private int tang;
    public int Nam
    {
        get
        {
            return nam;
        }
        set
        {
            nam = value;
        }
    }
    public int Tang
    {
        get
        {
            return tang;
        }
        set
        {
            tang = value;
        }
    }
    public override void Input()
    {
        base.Input();
        System.Console.WriteLine("Nhap nam ");
        Nam = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Nhap tang ");
        Tang = int.Parse(System.Console.ReadLine());
    }
    public override void Show()
    {
        base.Show();
        System.Console.WriteLine("Nam: {0} | Tang: {1}",this.Nam,this.Tang);
    }
    public override int Kind()
    {
        return 2;
    }
}
