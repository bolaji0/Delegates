namespace Delegates
{
    internal class Program
    {
        //delegate with no return type and 2 parameters
        // delegate void Calculate(int num, int num2);

        //delegate with no return and no parameter
        // delegate void Animal();

        //delegate with return type and parameters
        //delegate int Calculate(int num, int num2, int num90);

        //delegate with return type and parameter
        //delegate void Church(string name);


        //How many types can func and action take
        static void Main(string[] args)
        {
            Method methods = new Method();


            Func<int, int, int> paramAndReturn = methods.FuncMethod;
            Console.WriteLine(paramAndReturn(50, 50));

            Action<string> acString = HelloWorld;
            acString("Rengoku");


            //Method that is not in a class

            void HelloWorld(string name)
            {
                Console.WriteLine($"Hello World {name}");
            }

          



            //Action Delegate
            //Action<int, int> actionDelegate = methods.Add;
            //actionDelegate.Invoke(70, 10);


            //Church church = methods.PAstorsName;
            //church.Invoke("Pastor Dipo");

            // Calculate calculate = methods.Add;

            // Calculate calculates = methods.Subtract;

            //Multicast Delegate
            //calculate += methods.Subtract;

            //calculates.Invoke(500, 300);
            // calculate(20, 30);

            // Animal animal = methods.SayHello;
            //animal += methods.sayName;
            //animal();




            //Calculate calc = methods.Add;
            //Console.WriteLine(calc.Invoke(30, 49, 50));


        }



       
    }
}