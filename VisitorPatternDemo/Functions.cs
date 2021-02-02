using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Functions : IVisitor
{
    SalaryContainer salC;
    public void Visit(SalaryContainer obj)
    {
        salC = obj;
    }

    public int ReadAvail()
    {
        return salC.EmpSal;
    }

    public void UpdateMaxSal(int max)
    {
        salC.Max = max;
    }

    public void UpdateMinSal(int min)
    {
        salC.Min = min;
    }
}
