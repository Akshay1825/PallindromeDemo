using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindomeDemo.Model
{
    internal class Pallindrome
    {
        public bool IsPallindrome(int num)
        {
            int temp = num;
            int reverse = 0;

            while (temp > 0)
            {
                int remainder = temp % 10;
                reverse = (reverse * 10) + remainder;
                temp /= 10;
            }
            return reverse == num;
        }
    }
}
