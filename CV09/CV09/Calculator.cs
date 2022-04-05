using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV09
{
    internal class Calculator
    {
        private Stav _stav = Stav.PrveCislo;
        private Operacia _operacia;
        private enum Stav
        {
            PrveCislo,
            Operacia,
            DruheCislo,
            Vysledok
        };
        private enum Operacia
        {
            Plus,
            Minus,
            Multiply,
            Divide
        };
        private string firstNumber;
        private string secondNumber;
        public String Display
        { get; set; }
        public String Pamet
        { get; set; }
        public void Tlacitko(String btn)
        {
            var number ="";
            switch(btn)
            {
                case "1":
                    number += 1;
                    break;
                case "2":
                    number += 2;
                    break;
                case "3":
                    number += 3;
                    break;
                case "4":
                    number += 4;
                    break;
                case "5":
                    number += 5;
                    break;
                case "6":
                    number += 6;
                    break;
                case "7":
                    number += 7;
                    break;
                case "8":
                    number += 8;
                    break;
                case "9":
                    number += 9;
                    break;
                case "0":
                    number += 0;
                    break;
                case "+":
                    _stav = Stav.Operacia;
                    _operacia = Operacia.Plus;
                    Display = "+";
                    break;
                case "-":
                    _stav = Stav.Operacia;
                    _operacia = Operacia.Minus;
                    Display = "-";
                    break;
                case "*":
                    _stav = Stav.Operacia;
                    _operacia = Operacia.Multiply;
                    Display = "*";
                    break;
                case "/":
                    _stav = Stav.Operacia;
                    _operacia = Operacia.Divide;
                    Display = "/";
                    break;
                case "=":
                    _stav = Stav.Vysledok;
                    Display = Vysledok(firstNumber, secondNumber);
                    firstNumber = "";
                    secondNumber = "";
                    break;
                case ",":
                    number += ",";
                    break;
                case "<-":
                    if(_stav == Stav.PrveCislo)
                    {
                        firstNumber = firstNumber.Substring(0, firstNumber.Length - 1);
                    }
                    else if (_stav == Stav.DruheCislo)
                    {
                        secondNumber = secondNumber.Substring(0, secondNumber.Length - 1);
                    }
                    break;
                case "CE":
                    if (_stav == Stav.PrveCislo)
                    {
                        firstNumber = "";
                        Display = firstNumber;
                    }
                    else if (_stav == Stav.DruheCislo)
                    {
                        secondNumber = "";
                        Display = secondNumber;
                    }
                    break;
                case "C":
                    firstNumber = "";
                    secondNumber = "";
                    Pamet = "";
                    break;
                case "MS":
                    if (_stav == Stav.PrveCislo)
                    {
                        Pamet = Display;
                    }
                    else if (_stav == Stav.DruheCislo)
                    {
                        Pamet = secondNumber;
                    }
                    break;
                case "MR":
                    if (_stav == Stav.PrveCislo)
                    {
                        firstNumber = Pamet;
                        Display = firstNumber;
                    }
                    else if (_stav == Stav.DruheCislo)
                    {
                        secondNumber = Pamet;
                        Display = secondNumber;
                    }
                    break;
                case "M+":
                    if (_stav == Stav.PrveCislo)
                    {
                        _operacia = Operacia.Plus;
                        if(firstNumber != "")
                        {
                            Pamet = Vysledok(Pamet, firstNumber);
                        }
                        else
                            Pamet = Vysledok(Pamet, Display);
                    }
                    else if (_stav == Stav.DruheCislo)
                    {
                        _operacia = Operacia.Plus;
                        Pamet = Vysledok(Pamet,secondNumber);
                        if (secondNumber != "")
                        {
                            Pamet = Vysledok(Pamet, secondNumber);
                        }
                        else
                            Pamet = Vysledok(Pamet, "0");
                    }
                    break;
                case "M-":
                    if (_stav == Stav.PrveCislo)
                    {
                        _operacia = Operacia.Minus;
                        if (firstNumber != "")
                        {
                            Pamet = Vysledok(Pamet, firstNumber);
                        }
                        else
                            Pamet = Vysledok(Pamet, Display);
                    }
                    else if (_stav == Stav.DruheCislo)
                    {
                        _operacia = Operacia.Minus;
                        if (secondNumber != "")
                        {
                            Pamet = Vysledok(Pamet, secondNumber);
                        }
                        else
                            Pamet = Vysledok(Pamet, "0");
                    }
                    break;
                case "MC":
                    Pamet = "";
                    break;
                default:
                    break;

            }
            switch(_stav)
            {
                case Stav.PrveCislo:
                    firstNumber += number;
                    Display = firstNumber;
                    break;
                case Stav.DruheCislo:
                    secondNumber += number;
                    Display = secondNumber;
                    break;
                case Stav.Operacia:
                    _stav = Stav.DruheCislo;
                    break;
                case Stav.Vysledok:
                    _stav = Stav.PrveCislo;
                    break;
            }
        }
        public String Vysledok(string firstnumber, string secondnumber)
        {
            double first = Convert.ToDouble(firstnumber);
            double second = Convert.ToDouble(secondnumber);
            double ans = 0;
            switch(_operacia)
            {
                case Operacia.Plus:
                    ans = first + second;
                    return ""+ans;
                case Operacia.Minus:
                    ans = first - second;
                    return ""+ans;
                case Operacia.Multiply:
                    ans = first * second;
                    return "" + ans;
                case Operacia.Divide:
                    if (second != 0)
                    {
                        ans = first / second;
                        return "" + ans;
                    }
                    else
                        throw new DivideByZeroException();
                default:
                    return null;
            }
        }

    }
}
