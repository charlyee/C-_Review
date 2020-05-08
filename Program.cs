using System;
using System.Linq; //To use Linq methods on our arrays
using System.IO; //To read from files

namespace C__Review
{
    class Program
    {
        static void mySimpleMethod() //Simple method with return of void
        {
            Console.WriteLine("My method just ran.");
        }
        static void myParamMethod(string firstName, string lastName) //Method which accepts two parameters and returns void
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }
        static int myOverloadMethod(int x, int y) //Method overload accepting and returning ints
        {
            return x + y;
        }       
        static double myOverloadMethod(double x, double y) //Method overload accepting and returning doubles
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            /*Datatypes*/
            int number = 2147483647; //range: -2,147,483,648 to 2,147,483,647
            Console.WriteLine(number);
            long longnumber = 12147483647; //range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Console.WriteLine(longnumber);
            float decimalnumber = 3.141592f; //range: 6-9 digits
            Console.WriteLine(decimalnumber);
            double longdecimalnumber = 3.14159265358979; //range: 15-17 digits
            Console.WriteLine(longdecimalnumber);
            decimal reallylongdemicalnumer = 3.1415926535897932384626433832m; //range: 28-29 digits
            Console.WriteLine(reallylongdemicalnumer);
            char myChar = 'a'; //single character
            Console.WriteLine(myChar);
            string myString = "Hello World!"; //multiple characters
            Console.WriteLine(myString);
            bool myTruth = false; //true or false only
            Console.WriteLine(myTruth);

            /*Operations:*/

            /*Arithmetic*/
            int n = 2;
            int i = 3;

            int addResult = i + n; //addition
            Console.WriteLine(addResult);

            int subtractResult = i - n; //subtraction
            Console.WriteLine(subtractResult);

            int multiplicationResult = i * n; //multiplication
            Console.WriteLine(multiplicationResult);

            int divisionResult = i/n; //division
            Console.WriteLine(divisionResult);

            int modulusResult = i % n; //modulus - remainder after division
            Console.WriteLine(modulusResult);

            int incrementResult = i++; //incrementing by one
            Console.WriteLine(incrementResult);

            int decrementResult = n--; //decrementing by one
            Console.WriteLine(decrementResult);

            /*Comparison*/
            Console.WriteLine(i>n);
            Console.WriteLine(i<n);
            Console.WriteLine(i==n);
            Console.WriteLine(i>=n);
            Console.WriteLine(i<=n);
            Console.WriteLine(i!=n);

            /*Logical*/

            Console.WriteLine(i>n && i > 0); //AND statement - both sides must be true
            Console.WriteLine(i<n || i > 0); //OR statement - only one side must evaluate to true
            Console.WriteLine(!true); // NOT statement - used to reverse logical states

            /*User Inputs*/
            Console.WriteLine("Prompt: Please Enter Your Name:"); //prompt not necessary, but helps with user understanding
            string myName = Console.ReadLine();
            Console.WriteLine("Welcome: " + myName);

            /*Math Methods*/
            Console.WriteLine(Math.Max(2,3)); //returns highest of two values
            Console.WriteLine(Math.Min(2,3)); //returns lowest of two values
            Console.WriteLine(Math.Sqrt(81)); //returns squareroot 
            Console.WriteLine(Math.Abs(-5)); //returns absolute value
            Console.WriteLine(Math.Round(2.75)); //returns number rounded to nearest whole

            /*String Methods*/

            string myGreeting = "Hello there";

            Console.WriteLine(myGreeting.Length); //returns number of characters (spaces included)

            Console.WriteLine(myGreeting.ToUpper()); //All alphabetical characters are set to upper case

            Console.WriteLine(myGreeting.ToLower()); //All alphabetical characters are set to lower case

            string[] myGreetingArray = myGreeting.Split(" "); //Split by whatever is in the brackets (delimiter)
            foreach (string element in myGreetingArray){
                Console.WriteLine(element);
            }

            string fullGreeting = $"{myGreeting}, {myName}."; //String Interpolation
            Console.WriteLine(fullGreeting);

            string fullGreeting2 = $"\"{myGreeting}, {myName}.\""; //Escape Character
            Console.WriteLine(fullGreeting2);

            /*if/else/else if statements*/

            string season = "Spring";

            if (season == "Fall") {
                Console.WriteLine("Its fall, leaves everywhere!");
            } else if (season == "Winter"){
                Console.WriteLine("Its winter, snow everywhere!");
            } else if (season == "Spring"){
                Console.WriteLine("Its spring, pollen everywhere!");
            } else if (season == "Summer"){
                Console.WriteLine("It's summer, bugs everywhere!");
            } else {
                Console.WriteLine("Error! Invalid season!"); //else statement used for error handling
            }

            /*Switch Statements*/

            season = "Summer";

            switch(season){
                case "Fall": 
                    Console.WriteLine("Its fall, leaves everywhere!");
                    break;
                case "Winter":
                    Console.WriteLine("Its winter, snow everywhere!");
                    break;
                case "Spring":
                    Console.WriteLine("Its spring, pollen everywhere!");
                    break;
                case "Summer":
                    Console.WriteLine("Its summer, bugs everywhere!");
                    break;
                default:
                    Console.WriteLine("Warning! Invalid season!"); //default is reserved for error checking/handling
                    break;
            }

            /*While/Do While Loop*/

            int counter = 0; 

            while (counter < 3){ //A while loop will check the condition before executing the code
                counter++;
                Console.WriteLine(counter);
            }

            Console.WriteLine("----------");

            counter = 0;

            do { //A do while loop will ensure the code executes at least once before condition is checked
                counter++;
                Console.WriteLine(counter);
            } while (counter < 3);

            Console.WriteLine("----------");

            /*For/Foreach loop*/

            int[] myNumArray = {1,2,3,4};
            for (int pos = 0; pos < myNumArray.Length; pos+=2){ //for (counter; condition; incrementer)
                myNumArray[pos] = myNumArray[pos] * 2;
            }

            foreach (int element in myNumArray){ //foreach (type variableName in arrayName)
                Console.WriteLine(element);
            }

            /*Array Methods*/

            string[] myNameArray = {"John", "Joe", "Bob"};

            Array.Sort(myNameArray); //Sort method sorts array either alphabetically or numerically, depending on data presented

            foreach (string element in myNameArray){
                Console.WriteLine(element); //print out our sorted array of names
            }

            Console.WriteLine("----------");

            /*New keyword*/
            int[] myNumbers; //myNumbers reserved, but the values are not declared

            myNumbers = new int[] {9,8,7}; //we must past the value and type with the new keyword to set a value for myNumbers

             foreach (int element in myNumbers){
                Console.WriteLine(element); //print out our array
            }

            Console.WriteLine("----------");

            /*Using Linq Methods on Arrays*/
            Console.WriteLine(myNumbers.Min()); //Finds Max number in array
            Console.WriteLine(myNumbers.Max()); //Finds Min number in array
            Console.WriteLine(myNumbers.Sum()); //Sums all values in array

            Console.WriteLine("----------");

            /*Methods*/

            mySimpleMethod(); //Simple method
            myParamMethod("John", "Smith"); //Methods with parameters
            Console.WriteLine(myOverloadMethod(1,2)); //Method overload
            Console.WriteLine(myOverloadMethod(3.14, 2.17)); //Method overload

            Console.WriteLine("----------");

            /*Files*/
            string readText = File.ReadAllText("example.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

            Console.WriteLine(File.Exists("example.txt")); //Returns true or false on if our file exists

            Console.WriteLine("----------");

            File.WriteAllText("nextexample.txt", "Hello Again, World!"); //creates file if it exists and adds content to it, overwrites file content if file exists
            readText = File.ReadAllText("nextexample.txt");
            Console.WriteLine(readText);
            File.Delete("nextexample.txt"); //Deletes a file
        }
    }
}
