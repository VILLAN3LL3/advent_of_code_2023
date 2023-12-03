using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace No_1
{
    public static class Interactor
    {
        public static int Interact() {
            var input = InputLoader.LoadInput();
            return Calculator.CalculateCalibrationValueSum(input);
        }
    }
}