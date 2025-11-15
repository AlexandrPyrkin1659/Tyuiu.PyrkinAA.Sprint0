using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tyuiu.PyrkinAA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] nembers)
        {
            var total = 0;
            for (var i = 0; i < nembers.Length; i++)
            {
                total = total + nembers[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            var index = 0;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }
    }
}
