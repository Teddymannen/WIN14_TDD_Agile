
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Customer
{
    private bool isBlacklisted;

    private string name;
    public Customer(string n,bool b)
    {
        name = n;
        isBlacklisted = b;
    }

	public Rent Rent
	{
		get;
		set;
	}
    public bool IsBlacklisted()
	{
        return isBlacklisted;
	}

	public string getName()
	{
        return name;
	}
}

