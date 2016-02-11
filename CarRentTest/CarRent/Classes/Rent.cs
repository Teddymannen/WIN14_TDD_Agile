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
using System.Windows.Forms;

public class Rent
{
    FamilyCar familyCar;
    SportCar sportCar;
    double penaltyCost;

    public Rent()
    {
        familyCar = new FamilyCar();
        sportCar = new SportCar();
    }

    public DateTime StartDate { get; set; }

    public int Days { get; set; }

    public Car SelectedCar { get; set; }

    public double TotalCost { get; set; }

    public bool PaymentAccepted { get; set; }

    public double CalcTotal(double milage, double days, string c)
    {        
        var total = 0.0;
        try 
        {
            if (c == "SportCar" && milage > 0 && days > 0)
            {
            var car = new SportCar();
                total = car.DailyCost * days + car.MilageCost * milage + 150;

        }
            else if (c == "FamilyCar" && milage > 0 && days > 0)
        {
            var car = new FamilyCar();
                total = car.DailyCost * days + car.MilageCost * milage + car.ExtraInsurance;
            }
            
        }
        catch (FormatException)
        {
            
            MessageBox.Show("You have entered non-numeric characters");
            
        }
        return total;
    }
    public DateTime setDate(DateTime d)
    {
       
        if (d >= DateTime.Today)
        {
            return d;
        }
        else
        {
            throw new Exception("Time Error");
        }

    }

    public Car ChooseCar(string carType)
    {
        if(carType == null)
        {
            throw new ArgumentNullException();
        }

        if(carType == "familycar")
        {
            return familyCar;
        }
        else if(carType == "sportcar")
        {
            return sportCar;
        }
        else
        {
            throw new ArgumentException(String.Format("{0} är ingen giltig biltyp", carType));
        }
    }

    public void CalculatePenalty(DateTime returnDate)
    {
        DateTime endDate = StartDate.AddDays(Days);
        TimeSpan dt = returnDate - endDate;
        var numberOfDaysOverdue = dt.TotalDays;
        penaltyCost = numberOfDaysOverdue * 50;
    }
}
