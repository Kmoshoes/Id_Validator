// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace Id_validator3;
    public class Id_OutPut
    {

        public void ID_Writter(string Id_Line){

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
        

    