class Teacher : Person
{
    private string address;
    public string Address
    {
        get
        {
            return address;
        }
        set
        {
            address = value;
        }
    }
    public override void Input()
    {
        base.Input();
        System.Console.WriteLine("Nhap dia chi: ");
        Address = System.Console.ReadLine();
    }
    public override void Show()
    {
        base.Show();
        System.Console.WriteLine("Dia chi: {0}",this.Address);
    }
    public override int Kind()
    {
        return 2;
    }
}
