namespace MathHelper
{
    public class MathHelper
    {
        static void Main(string[] args)
        {
            MathHelper math = new MathHelper();

            int intResult = math.Add(5,8);
            float floatResult = math.Add(4.5f, 6.8f);
            double doubleResult = math.Add(4.4, 3.7);

            Console.WriteLine($"Sum of integer values is: {intResult}");
            Console.WriteLine($"Sum of floating values is: {floatResult}");
            Console.WriteLine($"Sum of double values is: {doubleResult}");
        }
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method overloading is useful:
        // 1. It improves code reusability and readability.
        // 2. It makes the code more maintainable; it saves time and effort.
        // 3. it makes the methods more flexible, so that values of different data
        // types can be passed as arguments to the method.
    }
}