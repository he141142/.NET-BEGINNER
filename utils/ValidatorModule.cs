using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp2.utils
{
    class ValidatorModule
    {
        public static string validateName(string fullName) {
            string[] arrStr = fullName.Trim().Split(' ');
            for (int i = 0; i < arrStr.Length; i++) {
                arrStr[0] = arrStr[0].ToUpper();
            }
            return string.Join(" ",arrStr);
        }
    }
}
