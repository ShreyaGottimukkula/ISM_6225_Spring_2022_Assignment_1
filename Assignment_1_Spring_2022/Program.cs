/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();


            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are {0}:" + unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:" + diagSum);
            Console.WriteLine();


            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is: " + rotated_string);
            Console.WriteLine();


            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine()

            ;

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */


        private static string RemoveVowels(string s)
        {
            try
            {



                string final_string = "";
                foreach (char ch in s)
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
                        || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')// trying to compare every character ch in string S with all the vowels both upper and lower case.
                        continue;// if matched eliminating the char from final string by continueing with the flow.
                    else
                        // if not , adding the char to final string resulting in a vowel less string.
                        final_string = final_string + ch.ToString();
                }
                return final_string; //returning the final result
            }
            catch (Exception)
            {
                throw;
            }

        }


        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {

                string str1 = null;
                foreach (string ch in bulls_string1)//trying to iterate through each string in array of strings for bulls_string1.  

                {
                    str1 = str1 + ch; //Adding them and make it into one single string.
                }
                string str2 = null;
                foreach (string ch in bulls_string2)//trying to iterate through each string in array of strings for bulls_string2.
                {
                    str2 = str2 + ch; //Adding them and make it into one single string.

                }
                str1 = str1.ToLower();// conventing str1 to lowercase.
                str2 = str2.ToLower();// conventing str2 to lowercase.
                if (str1 == str2)  // comparing both of these strings to see if they match.
                    return true;// returning true if matched.
                else
                    return false;// returning false if not.


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {


                //if 

                int[] str = bull_bucks;
                int total = 0;
                foreach (int x in bull_bucks) //using nested loop to compare each elemet in the array with itself .
                {
                    int count = 0;
                    foreach (int y in str)//nested loop to see  if there are any repetions of the element more than once.
                    {
                        if (x == y)//comparing to see if a match has made .
                            count = count + 1;//maintainded a count of that element.
                    }
                    if (count < 2) // if the count is less than 1 , it is consdered as  unique.
                        total = total + x; // and sum of all such unique elements is calculated.
                }

                return total;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int res = 0;
                int len = bulls_grid.GetLength(1);
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++) // using nested loops asits a 2Dimentional array.
                    {
                        if (i == j) // condition for finding primary digonal elements 
                            res = res + bulls_grid[i, j]; // finding sum of primary daigonal elements.
                        if (i + j == len - 1) // condition for finding secondary digonal elements.
                            res = res + bulls_grid[i, j]; // finding sum ofsecondary daigonal elements.

                    }
                }
                if (len % 2 != 0) // condition to check if the size of 2D array is odd or even  
                    res = res - bulls_grid[len / 2, len / 2]; //if size is  odd , Middle most element will be added twice from above code ,hence  subtrating it once to get desired result.


                return res; //returning the final  result.
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {

                if (bulls_string is not null && indices is not null && bulls_string.Length == indices.Length)
                {
                    int length = bulls_string.Length; // finding length of input string.
                    char[] new_array = new char[length]; // new char array for output storage.
                    for (int j = 0; j < length; j++) // running loop to find the matching  position for each  element of input string.
                    {
                        new_array[indices[j]] = bulls_string[j];// trying to place each char in bulls_string to in the position of each element in indices.
                    }
                    return new string(new_array);
                }

                return bulls_string;// if input is  null returning the same.

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {


                String prefix_string = "";
                int count = 0;
                int i = 0;
                foreach (char e in bulls_string6) // using loop to indentidy the first occurence of the given character.
                {

                    if (ch == e && count < 1)
                    {
                        count = count + 1;
                        i = bulls_string6.IndexOf(e);// when matched, finding the position of the char.
                    }


                }
                for (int j = i; j >= 0; j--)// iterating backwards from the position of the first match.
                {
                    prefix_string = prefix_string + bulls_string6[j]; // reversing the string from the postion i to start.

                }
                for (int k = i + 1; k < bulls_string6.Length; k++) //iterationg from the position  i to the end of string.
                {
                    prefix_string = prefix_string + bulls_string6[k]; // adding the rest of the string as it is to the reverse string to obtain the whole result.

                }

                return prefix_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}
