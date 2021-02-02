interface IVisitor
{
    void Visit(SalaryContainer s);
}

interface IVisitable
{
    void Accept(IVisitor visitor);
}

class SalaryContainer : IVisitable
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public int Max { get; set; }
    public int Min { get; set; }
    public int EmpSal { get; set; }

    public SalaryContainer() { Max = 10000; Min = 5000; }

    public bool AddSalary(int sal)
    {
        if (sal >= Min && sal <= Max)
        {
            EmpSal = sal;
            return true;
        }
        return false;
    }

    public void RemoveItem()
    {
        EmpSal = 0;
    }
}

