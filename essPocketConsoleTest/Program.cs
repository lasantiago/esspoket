﻿using esspocketORM;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essPocketConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountRepository ac = new AccountRepository();
            Console.Write(ac.GetAll(new EsspocketDBContext()).ToList());
            Console.Read();
        }
    }
}
