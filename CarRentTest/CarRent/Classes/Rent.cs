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
    double discount;
    
    public Rent()
    {
        familyCar = new FamilyCar();
        sportCar = new SportCar();
        StartDate = DateTime.Today;
    }
    public bool IsBookingValid { get; set; }
    private DateTime startDate;

    public DateTime StartDate
    {
        get
        {
            return startDate;
        }
        set
        {
            if (value >= DateTime.Today)
            {
                startDate = value;
            }
            else
            {
                throw new Exception("Time Error");
            }
        }
    }

    private DateTime endDate;
    public DateTime EndDate
    {
        get
        {
            return endDate;
        }
        set
        {
            if (value >= StartDate)
            {
                endDate = value;
            }
            else
            {
                throw new Exception("Time Error");
            }
        }
    }

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

                    total = car.DailyCost * days + car.MilageCost * milage + car.ExtraInsurance + penaltyCost + discount;

                }
                else if (c == "FamilyCar")
                {
                    var car = new FamilyCar();
                    total = car.DailyCost * days + car.MilageCost * milage + car.ExtraInsurance + penaltyCost + discount;
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
    
    public double calcDaysRent(DateTime startDate, DateTime endDate)
    {
        var initialSetDate = (endDate - startDate).TotalDays;
        Days = (int)initialSetDate;
        return Days;
    }

    public bool ChooseCar(string carType)
    {
        if(carType == null)
        {
            throw new ArgumentNullException();
        }

        if(carType == "familycar")
        {
            SelectedCar = new FamilyCar();
            return true;
            // return familyCar;
        }
        else if(carType == "sportcar")
        {
            SelectedCar = new SportCar();
            return true;
            //return sportCar;
        }
        else
        {
            throw new ArgumentException(String.Format("{0} är ingen giltig biltyp", carType));
        }
    }
    public bool ValidatingInputValue()
    {
        if(StartDate!=null && EndDate!= null && SelectedCar!=null)
        {
            IsBookingValid = true;
        }
        else
        {
            IsBookingValid = false;
        }
        return IsBookingValid;
    }

    public void CalculatePenaltyOrDiscount(DateTime returnDate)
    {
        calcDaysRent(StartDate, EndDate);
        DateTime endDate = StartDate.AddDays(Days);
        TimeSpan dt = returnDate - endDate;
        var numberOfDaysOverdue = dt.TotalDays;
        if(numberOfDaysOverdue > 0)
        {
            penaltyCost = numberOfDaysOverdue * 200;
        }
        else if (numberOfDaysOverdue < 0)
        {
            discount = numberOfDaysOverdue * 100;
        }
    }

}
