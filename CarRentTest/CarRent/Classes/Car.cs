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

public abstract class Car
{
    public double DailyCost { get; set; }

    public double MilageCost { get; set; }

    public bool IsRented { get; set; }

    abstract public double ExtraInsurance { get; set; }
    public double MilesDriven { get; set; }

    public Car()
    {
        DailyCost = 100;
        MilageCost = 2;
        ExtraInsurance = 0;
    }

}

