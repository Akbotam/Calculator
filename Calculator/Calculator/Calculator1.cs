﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Calculator1
    {
        public double FirstNumber;
        public double SecondNumber;
        public string operation;
        public double result;

        public Calculator1 ()
        {
            FirstNumber = 0;
            SecondNumber = 0;

        }

        public void saveFirstNumber (string s)
        {
            FirstNumber = double.Parse(s);
        }
        public void saveSecondNumber (string s)
        {
            SecondNumber = double.Parse(s);
        }


        public void calculate()
        {
            switch(operation)
            {
                case "+": 
                    result = FirstNumber+SecondNumber;
                    break;
                case "-":
                    result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    result = FirstNumber / SecondNumber;
                    break;

            }
        }

        /*ublic double GetPlus()
        {
            return FirstNumber + SecondNumber;
        }
        public double GetMinus()
        {
            return FirstNumber - SecondNumber;

        }
        public double GetMul()
        {
            return FirstNumber * SecondNumber;
        }
        public double GetDiv()
        {
            return FirstNumber / SecondNumber;
        }*/
            
    }
}
