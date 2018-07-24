using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            string inputInLowerCase = input.ToLower();
            return alphabets.All(c => inputInLowerCase.Contains(c));
            //bool check = true;
            //string str = input.ToLower();
            //for (int i = 0; i < 26; i++)
            //{
            //    if (str.Contains(alphabets[i]) == false)
            //    {
            //        return check = false;
            //    }
            //}
            //return check;   
        }
    }
}
