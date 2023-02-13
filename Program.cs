// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace IdValidator
{
    class IdValidator
    {

        static void Main(String[] args){

            var Id_Lines = File.ReadLines("Id_list.txt");
            
            foreach (var Id_Line in Id_Lines){
                ID_date_Formater(Id_Line);
                                
            }
        }
        public static void ID_date_Formater(string Id_Line){

            //Checking if the character is a digit
            foreach (Char Id_int in Id_Line){
                if (!Char.IsDigit(Id_int)){
                    Console.WriteLine("Error: "+Id_Line);
                    continue;
                }
            }
                
            //Checking if the ID number has the valid length 
                if(Id_Line.Length == 13){
                        //Slices the date from the Id
                        var Year = Id_Line.Substring(0,2);
                        var Month = Id_Line.Substring(2,2);
                        var Day = Id_Line.Substring(4,2);

                        //Converts the Year into an integer
                        int yearNumber = Convert.ToInt32(Year);
                        // Console.WriteLine(yearNumber);

                        //Checks if the year is in the 90's or 20's
                        if(yearNumber < 30){
                            Console.WriteLine(Day+"/"+Month+"/"+"20"+Year);
                            ID_Writter(Id_Line);
                        }
                        else if(yearNumber > 30){
                            Console.WriteLine(Day+"/"+Month+"/"+"19"+Year);
                            ID_Writter(Id_Line);
                        }
                    }
                    //The Id has an error
                    else{
                        Console.WriteLine("Error: "+Id_Line);
                    }
        }

        public static void ID_Writter(string Id_Line){

                    //Slices the Id number year and converts it into an integer
                    var Year = Id_Line.Substring(0,2);
                    int yearNumber = Convert.ToInt32(Year);
                    
                    //Checking if the Id year is before or after 2010
                    if(yearNumber >= 10 && yearNumber < 30){
                        File.AppendAllText("BeforeAndAterList.txt"," - After 2010 - "+Id_Line+"\n");
                    }
                    else {
                        File.AppendAllText("BeforeAndAterList.txt"," - Before 2010 - "+Id_Line+"\n");
                    }

        }

    }
    
}