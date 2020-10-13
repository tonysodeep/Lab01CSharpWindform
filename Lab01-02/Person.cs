abstract class Person
{
    private string personID;
    private string fullName;
    public string PersonID
    {
        get
        {
            return personID;
        }
        set
        {
            personID = value;
        }
    }
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
    public virtual void Input()
    {
        System.Console.WriteLine("Nhap ID: ");
        PersonID = System.Console.ReadLine();
        System.Console.WriteLine("Nhap ho ten : ");
        FullName = System.Console.ReadLine();
    }
    public virtual void Show()
    {
        System.Console.WriteLine("ID: {0} | Ho ten: {1} ", this.PersonID, this.FullName);
    }
    public abstract int Kind();
}
