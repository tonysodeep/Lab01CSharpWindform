class ChungCu : DiaOcD
{
    private int tangChungCu;
    public int TangChungCu
    {
        get
        {
            return tangChungCu;
        }
        set
        {
            tangChungCu = value;
        }
    }
    public override void Input()
    {
        base.Input();
        System.Console.WriteLine("Nhap tang: ");
        TangChungCu = int.Parse(System.Console.ReadLine());
    }
    public override void Show()
    {
        base.Show();
        System.Console.WriteLine("Tang: "+this.TangChungCu);
    }

    public override int Kind()
    {
        return 3;
    }

}
