﻿using System;

namespace Day4
{



    public partial class Program
    {
        public class Calculator
        {
            public int Add(params int[] numbers)
            {
                var sum = 0;
                foreach (var number in numbers)
                {
                    sum += number;
                }
                return sum;
            }
        }
       



    }



 
}