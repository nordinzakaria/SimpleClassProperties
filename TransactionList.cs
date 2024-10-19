using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransactionList
{
    private List<Transaction> transactions = new List<Transaction>();

    public TransactionList()
    {
    }

    public void Add(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    public void Read(int num)
    {
        Console.WriteLine("Enter " + num + " transaction values:");

        for (int i = 0; i < num; i++)
        {
            Console.Write(" Enter Val, Day, Month, Year: ");
            string val = Console.ReadLine();
            string day = Console.ReadLine();
            string month = Console.ReadLine();
            string year = Console.ReadLine();

            Transaction tr = new Transaction(int.Parse(val), 
                            new Date(int.Parse(day), int.Parse(month), int.Parse(year)));
            Add(tr);
        }

    }

    public void Write()
    {
        Console.WriteLine("Transaction values:");
        for (int i = 0; i < transactions.Count; i++)
        {
            Console.WriteLine("Val: " + transactions[i].Val);
            Console.WriteLine("Day: " + transactions[i].Date.Day);
            Console.WriteLine("Month: " + transactions[i].Date.Month);
            Console.WriteLine("Year: " + transactions[i].Date.Year);
        }
    }

}

