namespace Student_Pairing_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creeting a list
            //do-while loop for names
            //
            List<string> names = new List<string> ();

            bool name = true; 

            do
            {

                Console.WriteLine("Please enter your name");
                string userInput = Console.ReadLine();

                names.Add(userInput); //add to the list above

                Console.WriteLine("Press Esc or Y to add another name");
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    name = false;
                }

            } while (name);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


            //Divide into two groups
            //Iterate through two groups
            //Random numbers

            while (names.Count() > 0)
            {
                if (names.Count() % 2 == 1)
                {
                    Console.WriteLine($"{names[0]}, {names[1]}, {names[2]}"); 

                    names.RemoveRange(0, 3); // kicks the names out the list
                }

                else
                {
                    Console.WriteLine($"{names[0]}, {names[1]} "); //names divided into list

                    names.RemoveRange(0, 2);
                }
            }
            
        }
    }
}