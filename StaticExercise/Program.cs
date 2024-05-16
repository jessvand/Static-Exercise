namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FarenheitToCelsius(39);

            Console.WriteLine($"39 Farenheit is {celsius} degrees in Celsius");

            var farenheit = TempConverter.CelsiusToFarenheit(celsius);

            Console.WriteLine($"It's {farenheit} degrees when convertd back to Celsius" );
        }
    }
}
