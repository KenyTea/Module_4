﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
using KKB.Bank.Module;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> ListClient = new List<Client>();

            GeneratorName.Generator g = new Generator();

            Client c1 = new Client();

            c1.DoB = DateTime.Now.AddYears(-60);
            c1.FoolName = g.GenerateDefault(Gender.man);
            c1.IIN = "970131301448";
            c1.Login = "Qwe";
            c1.Password = "123";
            c1.PhoneNumber = "87772223331";

            ListClient.Add(c1);

        }
    }
}
