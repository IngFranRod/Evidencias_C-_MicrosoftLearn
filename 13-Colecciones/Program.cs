namespace colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.Make = "Oldsmobile";
            //car1.Model = "Cutlas Supreme";
            //car1.VIN = "A1";

            //Car car2 = new Car();
            //car2.Make = "Geo";
            //car2.Model = "Prism";
            //car2.VIN = "B1";

            //Book book = new Book();
            //book.Title = "Fran";
            //book.Authot = "Mic";
            //book.ISBN = "0-000-00000-0";

            //ArrayList myArraylist = new ArrayList();
            //myArraylist.Add(car1);
            //myArraylist.Add(car2);
            //myArraylist.Add(book);
            //myArraylist.Remove(book);

            //foreach (Car car in myArraylist)
            //{
            //    Console.WriteLine(car.Make);
            //}

            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);       
            ////myList.Add(book);
            //foreach(Car car in myList)
            //{
            //    Console.WriteLine(car.Model);
            //}

            //string[] names = { "Bob", "Steve", "Brian", "Chuck"};

            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3"};
            //Car car2 = new Car() { Make = "BMW", Model = "M4", VIN = "C4" };


        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Authot { get; set; }
        public string ISBN { get; set; }
    }
}