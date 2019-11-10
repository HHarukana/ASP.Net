using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Validator
{
    public static bool gotBadWords(string temp)
    {
        bool blnResult = false;
        string[] strBadWords = { "Poop", "Homework", "Crap" };

        foreach (string strBW in strBadWords)
            if (temp.Contains(strBW))
            {
                blnResult = true;


            }
        return blnResult;

    }

    public static bool isValidState(string temp)
    {
        bool result = false;

        if (temp.Length == 2)
        {
            result = true;


        }

        return result;



    }



    public static bool isvalidNumber(string temp)
    {
        bool result = false;

        //checks each character in a string is a digit
        foreach (char i in temp)
        {
            if (!char.IsDigit(i) && i != '.')
            {
                result = false;
            }
            else
            {
                result = true;

            }


        }





        return result;


    }

    public static bool GotPoop(string temp)
    {
        bool result = false;

        if (temp.Contains("Poop"))
        {
            result = true;
        }

        return result;
    }



    public static bool IsitFilledin(string temp)
    {
        bool result = false;

        if (temp.Length > 0)
        {
            result = true;
        }

        return result;
    }

    public static bool IsAFutureDate(DateTime temp)
    {
        bool blnResult;

        if (temp <= DateTime.Now)
        {

            blnResult = false;
        }
        else
        {
            blnResult = true;
        }




        return blnResult;
    }

    public static bool isCapital(string temp)
    {
        bool result = false;
        //Checks each character in a string to see if the letters are capital
        foreach (char i in temp)
        {
            if (char.IsLower(i))
            {

                result = false;
            }
            else
            {
                result = true;
            }


        }


        return result;
    }


    //Recieves a string and checks for valid email format
    public static bool isValidEmail(string temp)
    {
        bool blnResult = true;

        //Look for position of "@"
        int atLocation = temp.IndexOf("@");
        int nextLocation = temp.IndexOf("@", atLocation + 1);

        //Look for position of last period
        int periodLocation = temp.LastIndexOf(".");

        //Check minimum length
        if (temp.Length < 8)
        {

            blnResult = false;


        }
        else if (atLocation < 2)
        {
            blnResult = false;
        }
        else if (periodLocation + 2 > (temp.Length))
        {

            blnResult = false;
        }

        return blnResult;
    }

    public static bool IsMinimumAmount(int temp, int min)
    {
        bool blnResult;

        if (temp >= min)
        {
            blnResult = true;

        }
        else
        {
            blnResult = false;
        }
        return blnResult;


    }

    public static bool IsMinimumAmount(double temp, double min)
    {
        bool blnResult;

        if (temp >= min)
        {
            blnResult = true;
        }
        else
        {
            blnResult = false;
        }
        return blnResult;
    }


    public static bool isvalidZip(string temp)
    {
        bool blnResult;

        if (temp.Length == 5)
        {

            blnResult = true;

        }
        else
        {
            blnResult = false;

        }


        return blnResult;
    }

    public static bool isvalidPhone(string temp)
    {
        bool blnResult;

        if (temp.Length == 10)
        {

            blnResult = true;
        }
        else
        {
            blnResult = false;

        }

        return blnResult;
    }
}