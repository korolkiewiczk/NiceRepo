﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new Logic(new Answers());

            while (true)
            {
                logic.Start();
            }
        }
    }
}
