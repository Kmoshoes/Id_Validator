﻿// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using Id_validator3;
using System.Text.RegularExpressions;


namespace Id_validator2;
public class Id_Input
{

    string Year = "";
    string Month = "";
    string Day = "";


    void Id_Digit_Checker(string Id_Line)
    {
        foreach (Char Id_int in Id_Line)
        {
            if (!Char.IsDigit(Id_int))
            {
                Console.WriteLine("Error: " + Id_Line);
                continue;
            }
        }

    }

    void Id_Slicer(string Id_Line)
    {
        //Slices the date from the Id
        Year = Id_Line.Substring(0, 2);
        Month = Id_Line.Substring(2, 2);
        Day = Id_Line.Substring(4, 2);

    }

    bool validLength(string Id_Line)
    {
        return Regex.IsMatch(Id_Line, @"\d{13}");
    }

    bool dateOfBirth(string Id_Line)
    {
        //The first 6 digits (YYMMDD)

        return Regex.IsMatch(Id_Line, @"");

    }

    bool gender(string Id_Line)
    {
        //The next 4 digits (SSSS)
        return Regex.IsMatch(Id_Line, @"");

    }

    bool saCitizen(string Id_Line)
    {
        //The next digit (C)
        return Regex.IsMatch(Id_Line, @"");

    }

    bool valid(string Id_Line)
    {
        //The last digit (Z)
        return Regex.IsMatch(Id_Line, @"");

    }
    public void ID_date_Formater(string Id_Line)
    {

        Id_OutPut id_OutPut = new Id_OutPut();

        //Checking if the character is a digit
        Id_Digit_Checker(Id_Line);




        //Checking if the ID number has the valid length 
        if (Id_Line.Length == 13)
        {
            Id_Slicer(Id_Line);


            //Converts the Year into an integer
            int yearNumber = Convert.ToInt32(Year);
            // Console.WriteLine(yearNumber);

            //Checks if the year is in the 90's or 20's
            if (yearNumber < 30)
            {
                Console.WriteLine(Day + "/" + Month + "/" + "20" + Year);
                id_OutPut.ID_Writter(Id_Line);
            }
            else if (yearNumber > 30)
            {
                Console.WriteLine(Day + "/" + Month + "/" + "19" + Year);
                id_OutPut.ID_Writter(Id_Line);
            }
        }
        //The Id has an error
        else
        {
            Console.WriteLine("Error: " + Id_Line);
        }
    }

    public IEnumerable<string> readFile()
    {

    }
}
