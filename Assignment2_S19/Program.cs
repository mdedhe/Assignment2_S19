using System;
using System.Collections.Generic;
using System.Collections;
namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine(findMedian(arr2));
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.WriteLine("Press any key for next question..");
            Console.ReadKey(true);
        }

        static void displayArray(int []arr) {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            return new int[] {};
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            return 0;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            return "";
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
             ArrayList l = new ArrayList();
            int[] uArray = new int[arr.Length];
            uArray = getUniqueArray(brr);
            for (int i = 0; i < uArray.Length; i++)
            {
                int countb = 0;
                for (int j = i; j < brr.Length; j++)
                {
                    // count inside it the each number count
                    if (uArray[i] == brr[j])
                    {
                        countb++;
                    }// end of if statement
                }// end of the inner for
                // now compare the count with the original array
                int counta = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (uArray[i] == arr[k])
                    {
                        counta++;
                    }// end of if statement
                }// end of the original array brr for one iteration of arr[]   
                if (countb == counta)
                    continue;
                else
                    l.Add(uArray[i]);
            }// end of for loop
            // create the missing term array 
            int[] finalArr = new int[l.Count];
            int c = 0;
            foreach (int i in l)
            {
                finalArr[c] = i;
                c++;
            }// end of foreach 
            return finalArr;
        }
         static int[] getUniqueArray(int[] brr)
        {
            int[] sarr = sortArray(brr);
            ArrayList l = new ArrayList();
            for (int i = 0; i < sarr.Length; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if (sarr[i] == sarr[j])
                        break;
                }
                if (i == j)
                    l.Add(sarr[i]);
            }// end of for loop
            // create the Unique array 
            int[] UniArr = new int[l.Count];
            int c = 0;
            foreach (int i in l)
            {
                UniArr[c] = i;
                c++;
            }// end of foreach
            return UniArr;
        }
        static int[] sortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }// end of if statement
                }// end of innermost for loop
            }// end of for loop
            return arr;
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            int[] newgrades = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    int multipleOfFive = grades[i] / 5;
                    int reminderOfFive = grades[i] % 5;
                    int reminder = ((multipleOfFive + 1) * 5) - grades[i];
                    if (reminderOfFive == 0)
                    {
                        newgrades[i] = grades[i];
                    }// end of if statement
                    else if (reminder < 3)
                    {
                        newgrades[i] = (multipleOfFive + 1) * 5;
                    }// end of elseif statement
                    else
                    {
                        newgrades[i] = grades[i];
                    }// end of else statement
                }// end of if statement
                else
                {
                    newgrades[i] = grades[i];
                }// end of else statement
            }// end of for loop
            return newgrades;
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            
            int median = 0;
            int[] arrNew = sortArray(arr);
            int mid = arrNew.Length / 2;
            if (mid % 2 == 0)
            {
                median = (arrNew[mid] + arrNew[mid + 1]) / 2;
            }// end of if statement
            else
            {
                median = arrNew[mid];
            }// end of else statement
            return median;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            int[] arrNew = sortTheArray(arr);
            int findTheMinDiff = findtheDiff(arrNew);
            int[] returnArray = finalSol(arrNew, findTheMinDiff);

            return returnArray;
        }
        static int[] finalSol(int[] arr, int min)
        {
            ArrayList l = new ArrayList();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int differ = arr[i + 1] - arr[i];
                if (differ == min)
                {
                    l.Add(arr[i]);
                    l.Add(arr[i + 1]);
                }
            }
            int[] finalArray = new int[l.Count];
            int k = 0;
            foreach (int i in l)
            {
                finalArray[k] = i;
                k++;
            }
            return finalArray;
        }
        static int findtheDiff(int[] arr)
        {
            int diff = arr[1] - arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int differ = arr[i + 1] - arr[i];
                if (differ < diff)
                {
                    diff = differ;
                }
            }
            return diff;
        }
        static int[] sortTheArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }


        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            String finalDate = "";
            if (year >= 1919)
                finalDate = getTheDateGregorian(year);
            else if (year <= 1917)
                finalDate = getTheDateJulian(year);
            else
                finalDate = getTheDate1918(year);
            //return the date to the function 
            return finalDate;
        }
        static string getTheDateGregorian(int year)
        {
            String finalDate = "";
            //on the basis of sum of months in Leap year
            int daystillAugustLYear = 244;
            //on the basis of sum of months in normal year 
            int daystillAugustYear = 243;
            bool isLeap = isLeapYearGregorian(year);
            if (isLeap == false)
            {
                int date = 256 - daystillAugustYear;
                String format = date.ToString() + ".09." + year.ToString();
                finalDate = format;
            }
            else
            {
                int date = 256 - daystillAugustLYear;
                String format = date.ToString() + ".09." + year.ToString();
                finalDate = format;
            }
            return finalDate;
        }
        static string getTheDateJulian(int year)
        {
            String finalDate = "";
            //on the basis of sum of months in Leap year
            int daytillAugustLYear = 244;
            //on the basis of sum of months in normal year 
            int daystillAugustYear = 243;
            bool isLeap = isLeapYearJulian(year);
            if (isLeap == false)
            {
                int date = 256 - daystillAugustYear;
                String format = date.ToString() + ".09." + year.ToString();
                finalDate = format;
            }
            else
            {
                int date = 256 - daytillAugustLYear;
                String format = date.ToString() + ".09." + year.ToString();
                finalDate = format;
            }
            return finalDate;
        }
        static string getTheDate1918(int year)
        {
            String finalDate = "";
            //because here after the date of 31st Jan directly 14th Feb is there so 
            int daytillAugustLYear = 230;
            int date = 256 - daytillAugustLYear;
            String format = date.ToString() + ".09." + year.ToString();
            finalDate = format;
            return finalDate;
        }
        static bool isLeapYearJulian(int year)
        {
            bool flag = false;

            if (year % 4 == 0)
                flag = true;

            return flag;
        }

        static bool isLeapYearGregorian(int year)
        {
            bool flag = false;

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                flag = true;

            return flag;
        }

    }
}
