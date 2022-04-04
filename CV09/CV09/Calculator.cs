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
        public String Memory
        { get; set; }
        public void Btn(String btn)
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
                    break;
                case "-":
                    _stav = Stav.Operacia;
                    _operacia = Operacia.Minus;
                    break;
                case "*":
                    _stav = Stav.Operacia;
                    _operacia = Operacia.Multiply;
                    break;
                case "/":
                    _stav = Stav.Operacia;
                    _operacia = Operacia.Divide;
                    break;

            }
            switch(_stav)
            {
                case Stav.PrveCislo:
                    firstNumber = number;
                    Display = firstNumber;
                    break;
                case Stav.DruheCislo:
                    secondNumber = number;
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

    }
}
