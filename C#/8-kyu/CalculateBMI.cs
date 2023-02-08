/*
Write function bmi that calculates body mass index (bmi = weight / height2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese"
*/

public class Kata
{
    public static string Bmi(double weight, double height)
    {
        string result = "";
        double bmi = weight /(height * height);
        switch (bmi)
        {
            case double n when ( n <= 18.50):
                result = "Underweight";
                break;
            case double n when (n > 18.5 && n <= 25.0):
                result = "Normal";
                break;
            case double n when (n > 25.0 && n <= 30.0):
                result = "Overweight";
                break;
            case double n when (n > 30):
                result = "Obese";
                break;
        }

        return result;
    }
}