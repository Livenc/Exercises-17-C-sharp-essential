namespace Exercise_5;

    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            return a - b;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

           
            dynamic result1 = calculator.Add(1, 10);
           dynamic result2 = calculator.Subtract(false, 2);
            dynamic result3 = calculator.Multiply(2.5, 3);
            dynamic result4 = calculator.Divide(10, 9);

            
            Console.WriteLine("Addition result: {0}", result1);
            //Console.WriteLine("Subtraction result: {0}", result2);
            Console.WriteLine("Multiplication result: {0}", result3);
            Console.WriteLine("Division result: {0}", result4);

            Console.ReadKey();
        }
    }


    
