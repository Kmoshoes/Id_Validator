// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using Id_validator2;
using System.Collections.Generic;

namespace IdValidator
{
    class IdValidator
    {

        static void Main(String[] args){

        var Id_Lines =;
            
           
            
           

                try
                {
                    Id_Lines = File.ReadLines("Id_list.txt");
                }
                catch (System.Exception)
                {
                    
                    throw;
                }

                foreach (var Id_Line in Id_Lines){
                
                    Id_Input.ID_date_Formater(Id_Line);
                                
            }
        }
    }

    }
    