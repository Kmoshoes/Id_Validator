// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using Id_validator2;
using System.Collections.Generic;

namespace IdValidator
{
    class IdValidator
    {

        static void Main(String[] args)
        {

            Id_Input id_Input = new Id_Input();

            var Id_Lines = id_Input.readFile("Id_list.txt");

            foreach (var Id_Line in Id_Lines)
            {

                Id_Input.ID_date_Formater(Id_Line);

            }
        }
    }

}
