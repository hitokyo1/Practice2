using System;
class Workers
{
    private string name;
    private string surname;
    private int rate;
    private int days;
    public string Name
    {
        get { return name; }
        set { this.name = value; }
    }
    public string Surname
    {
        get { return surname; }
        set { this.surname = value; }
    }
    public int Rate
    {
        get { return rate; }
        set { this.rate = value; }
    }
    public int Days
    {
        get { return days; }
        set { this.days = value; }
    }
    public int GetSalary()
    {
        return this.rate * this.days;
    }
}