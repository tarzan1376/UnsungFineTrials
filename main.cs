using System;

class InchesToCentimeterslnteractive
{
    public static void Main(string[] args)
    {
        const double CENTIMETERS_PER_INCH = 2.54;

      
      Console.WriteLine("Please enter a number in Inches: ");
      var x = Console.ReadLine();
      int inches;
      if (int.TryParse(x, out inches)) {
      
      Console.WriteLine("{0} inches converts to {1} centimeters", inches, inches*CENTIMETERS_PER_INCH);
        }
    }
}