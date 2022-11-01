namespace Student_Pairing_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a list
            //do-while loop for names
            //
            List<string> names = new List<string> ();

            bool name = true; 

            do
            {

                Console.WriteLine("Please enter students name:");
                string userInput = Console.ReadLine();

                names.Add(userInput); //add to the list above

                Console.WriteLine("\nPress any key to add another name" +
                    "\nPress Esc to see list\n");
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    name = false;
                }

            } while (name);

            //Console.WriteLine("");
            //Console.WriteLine("");

            foreach (var item in names)
            {
                Console.WriteLine(item);                
            }
            Console.WriteLine("\n\n");
            //Console.WriteLine("");

            //Divide into two groups
            //Iterate through two groups
            //Random numbers

            int groupNum = 1;
            Random rand = new Random ();

            //Printing names into groups 
            while (names.Count() > 0)
            {
                if (names.Count() % 2 == 1)
                {
                    
                    string name1 = names[rand.Next(0, names.Count())];
                    names.Remove(name1);
                    string name2 = names[rand.Next(0, names.Count())];
                    names.Remove(name2);
                    string name3 = names[rand.Next(0, names.Count())];
                    names.Remove(name3);

                    Console.WriteLine($"Group{groupNum}: {name1}, {name2}, {name3}"); 

                    /*names.RemoveRange(0, 3);*/ // kicks the names out the list

                    groupNum++;
                }

                else
                {
                    string name1 = names[rand.Next(0, names.Count())];
                    names.Remove(name1);
                    string name2 = names[rand.Next(0, names.Count())];
                    names.Remove(name2);

                    Console.WriteLine($"Group{groupNum}:  {name1}, {name2} "); //names divided into list

                    //names.RemoveRange(0, 2);

                    groupNum++;
                }
            }
            
        }
    }
}