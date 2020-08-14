public class Employee
{
    private int _empID;
    private string _empName;
    private double _noOfHoursWorked;
    private double _hourlyPrice;
    public void SetEmpId(int value)
    {
        _empID = value;
    }

    public int GetEmpID()
    {
        return _empID;
    }
    public void SetEmpName(string value)
    {
        _empName = value;
    }

    public string GetEmpName()
    {
        return _empName;
    }
    public void SetNoOfHoursWorked(double value)
    {
        _noOfHoursWorked = value;
    }

    public double GetNoOfHoursWorked()
    {
        return _noOfHoursWorked;
    }

    public void SetHourlyPrice(double value)
    {
        _hourlyPrice = value;
    }

    public double GetHourlyPrice()
    {
        return _hourlyPrice;
    }
    public double GetGrossSalary()
    {
        return _noOfHoursWorked * _hourlyPrice;

    }
    public double GetNetSalary()
    {
        if (GetGrossSalary() > 30000)
        {
            return GetGrossSalary() - ((GetGrossSalary() * 5) / 100);
        }
        else
        {
            return (GetGrossSalary());
        }
    }
}
