using System;
class Counter
{
    private int shetchick;
    public Counter()
    {
        this.shetchick = 0;
    }
    public Counter(int n)
    {
        this.shetchick = n;
    }
    public void shetchickOfLow()
    {
        this.shetchick--;
    }
    public void shetchickOfSum()
    {
        this.shetchick++;
    }
    public int Output
    {
        get { return shetchick; }
    }
}