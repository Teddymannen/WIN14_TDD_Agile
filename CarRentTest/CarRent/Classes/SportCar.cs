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

public class SportCar : Car
{
    double Insurance;
    public override double ExtraInsurance
    {
        get
        {
            if (Insurance > 150)
                return Insurance;
            else
                return 150;
        }
        set { Insurance = value; }
    }
}

