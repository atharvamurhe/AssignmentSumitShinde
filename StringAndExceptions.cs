using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSumitShinde
{
    public class StringAndExceptions
    {
        public static string str = "Atharva";
        public static string str2 = "Atharva Murhe";
        public static void StringMethods()
        {
            //Example of Clone() string function
            string strClone = (string)str.Clone();
            Console.WriteLine("Clone of str using Clone() " + strClone);

            //Example of Compare() string function
            Console.WriteLine("Comparing string using compare() " + String.Compare(str, strClone));

            //Example of CompareOrdinal() string function
            Console.WriteLine("Comparing string using CompareOrdinal() " + String.CompareOrdinal(str, strClone));

            //Example of CompareTo() string function
            Console.WriteLine("Comparing string using CompareTo() " + str.CompareTo(strClone));

            //Example of concat() string function
            Console.WriteLine("Comparing string using Concat() " + String.Concat(str, strClone));

            //Example of Compare() string function
            if (str.Contains('A'))
            {
                Console.WriteLine(str + " Contains A");
            }
            else
            {
                Console.WriteLine(str + " Does not Contain A");
            }

            //Example of copy() string function
            strClone = String.Copy(str); //this method is obsolete

            //Example of copyto() string function
            string name = "Atharva Murhe";
            char[] onlySurname = { ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            name.CopyTo(7, onlySurname, 0, 5);
            Console.WriteLine("Full name = " + name);
            Console.WriteLine("Copied only surname = " + onlySurname);

            //Example of endswith() string function
            String[] strings = { "This is a string.", "Hello!", "Atharva.",
                           "IX.", "random" };
            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(".");
                if (endsInPeriod)
                {
                    Console.WriteLine($"{value} ends in a period"); //Prints each string that ends with '.'
                }
            }

            //Example of equals() string function
            bool isEqual = str.Equals(strClone);
            if (isEqual)
            {
                Console.WriteLine($"'{str}' is equal to '{strClone}'"); //Checks if both the strings are equal
            }
            else
            {
                Console.WriteLine($"'{str}' is not equal to '{strClone}'");
            }

            //Example of format() string function
            string dateTime = String.Format("It is now {0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(dateTime);

            //Example of GetEnumerator() string function
            CharEnumerator ch = str.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current + " "); //prints all chars from string one by one 
            }

            //Example of GetHashCode() string function
            Console.WriteLine(str.GetHashCode()); //prints the hashvalue of the string.

            //Example of GetType() string function
            Console.WriteLine("The object str is of type: {0}", str.GetType());

            //Example of GetTypeCode() string function
            Console.WriteLine("The type code of str is: " + Type.GetTypeCode(typeof(string)));

            //Example of IndexOf() string function
            Console.WriteLine("The index of 'h' in Atharva is: " + str.IndexOf('h'));

            //Example of Insert() string function
            Console.WriteLine("Updated string after insertion: " + str.Insert(7, " Murhe"));

            //Example of Intern() string function
            Console.WriteLine("Returns or creates the reference of string: " + string.Intern(str));

            //Example of IsInterned() string function
            string s1 = new string(new[] { 'a' });
            Console.WriteLine("Returns true if there is reference or false: {0}", string.IsInterned(s1) != null);

            //Example of IsNormalized() string function
            Console.WriteLine("The string '{0}' is normalized: {1}", str, str.IsNormalized());

            //Example of IsNullOrEmpty() string function
            Console.WriteLine("Is str null or empty: {0}", String.IsNullOrEmpty(str));

            //Example of IsNullOrWhiteSpace() string function
            Console.WriteLine("Is str null or contain white space: {0}", String.IsNullOrWhiteSpace(str));

            //Example of Join() string function
            string[] strArr = { "IncubXperts", "Technosolutions" };
            Console.WriteLine("Join elements of string array into on string: {0}", String.Join(" ", strArr));

            //Example of LastIndexOf() string function
            Console.WriteLine("The last index of a in str: {0}", str.LastIndexOf('a'));

            //Example of LastIndexOfAny() string function
            char[] charArr = { 'a', 't' };
            Console.WriteLine("the last index of any: {0}", str.LastIndexOfAny(charArr));

            //Example of Normalize() string function
            Console.WriteLine("Normalizing a string: {0}", str.Normalize());

            //Example of PadLeft() string function
            Console.WriteLine("left padding 4 white spaces: {0}", str.PadLeft(4));

            //Example of PadRight() string function
            Console.WriteLine("right padding 4 white spaces: {0}", str.PadRight(4));

            //Example of remove() string function
            Console.WriteLine("Remove chars from string from index 3: {0}", str.Remove(3));

            //Example of replace() string function
            Console.WriteLine("Replace chars from string: {0}", str.Replace('a', 'b'));

            //Example of split() string function
            string sentence = "The next example shows how to do this";
            Console.WriteLine("Split a string using a delimiter char:");
            string[] splitArr = sentence.Split(',');
            foreach (var subStr in splitArr)
            {
                Console.WriteLine(subStr);
            }

            //Example of StartsWith() string function
            Console.WriteLine("Returns true if string starts with A: {0}", str.StartsWith('A'));

            //Example of Substring() string function
            Console.WriteLine("Returns substring from a specified index of a string: {0}", sentence.Substring(10));

            //Example of tochararray() string function
            Console.WriteLine("Converts string to char array: ");
            charArr = str.ToCharArray();
            foreach (var ch1 in charArr)
            {
                Console.WriteLine($"{ch1} ");
            }

            //Example of ToLower() string function
            Console.WriteLine("Converts a string to all lower case chars: Original {0}, ToLower: {1}", str, str.ToLower());

            //Example of ToString() string function
            int num = 12345;
            Console.WriteLine("Converts different datatypes to string: {0}", num.ToString());

            //Example of ToUpper() string function
            Console.WriteLine("Converts all chars in string to upper case: Original: {0}, ToUpper: {1}", str, str.ToUpper());

            //Example of Trim() string function
            string str3 = "    Hello    ";
            Console.WriteLine("Trims trailing or starting white spaces in a string, Original: {0}, Trim: {1}", str3, str3.Trim());

            //Example of TrimEnd() string function
            Console.WriteLine("Trim trailing white spaces in a string:  Original: {0}, TrimEnd: {1}", str3, str3.TrimEnd());

            //Example of TrimStart() string function
            Console.WriteLine("Trim starting white spaces in a string:  Original: {0}, TrimStart: {1}", str3, str3.TrimStart());
        }

        public static void Exceptions()
        {
            int ans;
            int two = 2;
            int zero = 0;

            int[] arr = { 1 };

            string s = "hello";
            try
            {
                ans = two / zero;

                arr[1] = 100;

                int num = Convert.ToInt32(s);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Caught exception: {0}", e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Caught exception: {0}", e);
            }
            catch(Exception e)
            {
                Console.WriteLine("Caught exception: {0}", e);
            }
            finally
            {
                Console.WriteLine("Example execution completed..."); //prints this line even if exception occured.
            }
        }
    }
}
