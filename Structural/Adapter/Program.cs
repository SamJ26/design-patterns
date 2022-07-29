namespace Adapter
{
    /// <summary>
    /// This calculator work with Kilograms and Meters per second
    /// </summary>
    class PhysicsCalculator
    {
        /// <summary>
        /// Calculate kinetic energy
        /// </summary>
        /// <param name="m">Weight in kilograms</param>
        /// <param name="v">Velocity in meters per second</param>
        public double CalculateEk(double m, double v) => 0.5 * m * (v * v);
    }

    /// <summary>
    /// This calculator works with Pounds and Miles per second
    /// IT'S INTERFACE IS NOT COMPATIBLE WITH PhysicsCalculator
    /// </summary>
    interface IClientCalculator
    {
        /// <summary>
        /// Calculate kinetic energy
        /// </summary>
        /// <param name="m">Weight in pounds</param>
        /// <param name="v">Velocity in miles per second</param>
        /// <returns></returns>
        public double GetKineticEnergy(double m, double v);
    }

    /// <summary>
    /// Adapter which handles conversion between two types of units
    /// </summary>
    public class CalculatorAdapter : IClientCalculator
    {
        private readonly PhysicsCalculator adaptee = new();

        public double GetKineticEnergy(double m, double v)
        {
            var joules = adaptee.CalculateEk(PoundsToKgs(m), MilesPreSesToMetersPerSec(v));

            // Convert joules to Imperial units ??
            var result = joules;

            return result;
        }

        private double PoundsToKgs(double pounds) => pounds / 2.2;
        private double MilesPreSesToMetersPerSec(double mps) => mps * 1609.344;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CalculatorAdapter();

            double m = 50;   // Pounds
            double v = 5;   // Miles per second

            var res = calculator.GetKineticEnergy(m, v);

            Console.WriteLine(res);
        }
    }
}
