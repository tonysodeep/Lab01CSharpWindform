class KhuDat
{
    private string diaDiem;
    private double giaBan;
    private double dienTich;
    public string DiaDiem
    {
        get
        {
            return diaDiem;
        }
        set
        {
            diaDiem = value;
        }
    }
    public double GiaBan
    {
        get
        {
            return giaBan;
        }
        set
        {
            giaBan = value;
        }
    }
    public double DienTich
    {
        get
        {
            return dienTich;
        }
        set
        {
            dienTich = value;
        }
    }
    public virtual void Input()
    {
        System.Console.WriteLine("nhap dia diem ");
        DiaDiem = System.Console.ReadLine();
        System.Console.WriteLine("nhap gia ban ");
        GiaBan = double.Parse(System.Console.ReadLine());
        System.Console.WriteLine("nhap dien tich ");
        DienTich = double.Parse(System.Console.ReadLine());
    }
    public virtual void Show()
    {
        System.Console.WriteLine("dia diem: {0} | gia ban: {1} | dien tich: {2}", this.DiaDiem, this.GiaBan,this.DienTich);
    }

}
