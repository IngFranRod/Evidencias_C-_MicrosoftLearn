namespace Modificadores
{
    class Program
    {

        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);
            }
            Console.WriteLine("fuera del for: " + j);
            Console.WriteLine("fuera del for: " + k);

            Helper();
            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void Helper()
        {
            Console.WriteLine("Esto es un valor de K desde este metodo Helper(): " + k);
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(HelperM());
            }
            private string HelperM()
            {
                return "Hola Mundo!";
            }
        }

    }
}