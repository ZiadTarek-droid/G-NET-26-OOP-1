namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             * Class:
             * 1:Reference Type
             * 2:Stored in Heap
             * 3:Passed by reference
             * 4:Supports inheritance
             * ======================================
             * Struct:
             * 1:Value Type
             * 2:Stored in Stack
             * 3:Passed by value
             * 4:Does not support inheritance
             */
            #region Class Example
            //class PersonClass
            //  {
            //public string Name;
            //  }
            #endregion

            #region Struct Example
            //struct PersonStruct
            // {
            //   public string Name;
            // }
            #endregion

            // Class (Reference Type)
            //PersonClass p1 = new PersonClass();
            //p1.Name = "Ahmed";

            //PersonClass p2 = p1;
            //p2.Name = "Ali";

            //Console.WriteLine(p1.Name);
            // Output: Ali
            // Both variables reference the same object in memory

            // Struct (Value Type)
            //PersonStruct s1;
            //s1.Name = "Ahmed";

            //PersonStruct s2 = s1;
            //s2.Name = "Ali";

            //Console.WriteLine(s1.Name);
            // Output: Ahmed
            // A separate copy is created
            #endregion

            #region Q2
            // Public:
            //Accessible from anywhere in the program.
            // Private:
            //Accessible only inside the same class.

            //class Car
            //{
            //public string Brand;     // Accessible outside
            //private double Price;    // Not accessible outside

            //public void SetPrice(double price)
            //{
            //Price = price;
            //}

            //public void PrintInfo()
            //{
            //Console.WriteLine($"Brand: {Brand}");
            //Console.WriteLine($"Price: {Price}");
            //}
            //}
            //Car car = new Car();
            //car.Brand = "BMW";
            //car.SetPrice(500000);

            //car.PrintInfo();

            #endregion

            #region Q3
            /*
             * Steps to Create:

                Open Visual Studio

                 Click Create New Project

                    Choose Class Library (.NET)

                        Name your project

                            Click Create
            ==========================================
            Steps to Use It:

              Create another project (Console App)

                    Right-click on the project

                        Select Add → Project Reference

                            Choose the Class Library

                                Now you can use its classes
             */
            #endregion

            #region Q4
            /*
             * Definition:
               A Class Library is a project that contains reusable classes and methods.
            ==========================================
            Why we use it:
            1:Code reusability
            2:Better project organization
            3:Separation of concerns
            4:Easier maintenance
            5:Cleaner architecture
             */
            #endregion
        }
    }

}