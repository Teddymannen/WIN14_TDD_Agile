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

    public DateTime EndDate { get; set; }

    public Double TotalDaysRent { get; set; }

    public int Days { get; set; }

    public Car SelectedCar { get; set; }

    public double TotalCost { get; set; }

    public bool PaymentAccepted { get; set; }


    public double CalcTotal(double milage, double days, string c)
    {
        var total = 0.0;
        try
        {
            if (milage > 0 && days > 0)
                if (c == "SportCar")
                {
                    var car = new SportCar();

                    total = car.DailyCost * days + car.MilageCost * milage + car.ExtraInsurance + penaltyCost;

                }
                else if (c == "FamilyCar")
                {
                    var car = new FamilyCar();
                    total = car.DailyCost * days + car.MilageCost * milage + car.ExtraInsurance + penaltyCost;
                }
                else
                {
                    MessageBox.Show("Du har ej angivit godkänd typ av bil");
                }
            else
                MessageBox.Show("0 i värde är ej tillåtet");

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
    public double calcDaysRent(DateTime startDate, DateTime endDate)
    {
        var initialSetDate = (endDate - startDate).TotalDays;
        Days = (int)initialSetDate;
        return Days;
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
        calcDaysRent(StartDate, EndDate);
        DateTime endDate = StartDate.AddDays(Days);
        TimeSpan dt = returnDate - endDate;
        var numberOfDaysOverdue = dt.TotalDays;
        penaltyCost = numberOfDaysOverdue * 50;
    }
}
