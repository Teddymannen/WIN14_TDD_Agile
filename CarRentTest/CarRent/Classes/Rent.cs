﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rent
{
    private DateTime startDate;
    public DateTime StartDate {
        get
        { return startDate; }
        set
        {
               startDate = value; 
        }
    }

    public int Days { get; set; }

    public Car SelectedCar { get; set; }

    public double TotalCost { get; set; }

    public bool PaymentAccepted { get; set; }

    public double CalcTotal(double m, double d, string c)
    {
        var total = 0.0;
        if (c == "SportCar")
        {
            var car = new SportCar();
            total = car.DailyCost * d + car.MilageCost * m + car.ExtraInsurance;

        }
        else if (c == "FamilyCar")
        {
            var car = new FamilyCar();
            total = car.DailyCost * d + car.MilageCost * m;
        }
        return total;

    }
}
