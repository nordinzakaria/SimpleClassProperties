using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    public int Val { get; set; }
    public Date Date { get; set; }

    public Transaction() { }
    public Transaction(int val, Date date)
    {
        this.Val = val;
        this.Date = date;
    }
    
}