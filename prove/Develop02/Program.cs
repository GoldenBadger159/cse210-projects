using System;

class Program
{
    private static Journal journal = new Journal();
    private static Prompt prompt = new Prompt();
    static void Main(string[] args)
    {
        prompt._prompts.Add("What was the happiest thing about your day?");
        prompt._prompts.Add("Did anything unexpected happen today?");
        prompt._prompts.Add("What did I do for another today?");
        prompt._prompts.Add("What did someone do for me that made me happy?");
        prompt._prompts.Add("Was there anything that you would change about today?");
        
        void Menu()
        {
            string input = "0";
            do {
                Console.WriteLine("Home Page");
                Console.WriteLine("Please type the corresponding number to one of the options below:");
                Console.WriteLine("Quit(0)");
                Console.WriteLine("Write Entry(1)");
                Console.WriteLine("Display Journal(2)");
                Console.WriteLine("Add Prompt Options(3)");
                
                input = Console.ReadLine();

                if (input == "1")
                {
                    //Create an instance of the class Entry
                    Entry entry1 = new Entry();
                    //Get the current date
                    string date = entry1.GetDate();
                    //Provide a prompt
                    string currentPrompt = prompt.PromptGenerator();
                    Console.WriteLine(currentPrompt);
                    //Get users entry
                    string userEntry = Console.ReadLine();
                    //Get the quality of the day
                    Console.WriteLine("On a scale of 1-10 how was your day?");
                    string dayQual = Console.ReadLine();
                    int qual = int.Parse(dayQual);

                    int satisfied = 1;
                    do {
                        
                        //Ask the user if they would like to review their entry
                        Console.WriteLine("Would you like to review your entry? Yes/No: ");
                        string review = Console.ReadLine();
                        if (review == "Yes")
                        {
                            Console.WriteLine($"\n{date}\n{currentPrompt}\n{userEntry}\n your day was a {qual}\n");
                            int cont = 0;
                            do {
                                Console.WriteLine("\nAre you satisfied with this entry? Yes/No: ");
                                string inquiry = Console.ReadLine();
                                if (inquiry == "No")
                                {
                                    satisfied = 1;
                                    cont = 0;
                                } else if (inquiry == "Yes")
                                {
                                    //Saves info to the Entry class
                                    entry1._quality = qual;
                                    entry1._entry = $"\n{date}\n{currentPrompt}\n{userEntry}\n your day was a {qual}\n";
                                    //Saves info to the Journal class
                                    journal._entry = entry1._entry;
                                    //Saves the journal to a text file
                                    journal.WriteJournal(); 
                                    //Adds the qualities to a list
                                    journal._qualities.Add(qual);                                   
                                    satisfied = 1;
                                } else if (inquiry != "Yes" && inquiry != "No")
                                {
                                    Console.WriteLine("Please type a valid response.");
                                    satisfied = 0;
                                    cont = 1;
                                }
                            } while(cont != 0);
                        } else if (review == "No")
                        {
                            //Saves info to the Entry class
                            entry1._quality = qual;
                            entry1._entry = $"\n{date}\n{currentPrompt}\n{userEntry}\n your day was a {qual}\n";
                            //Saves info to the Journal class
                            journal._entry = entry1._entry;
                            //Saves the journal to a text file
                            journal.WriteJournal();
                            //Adds the qualities to a list
                            journal._qualities.Add(qual);                           
                            satisfied = 1;
                        } else if (review != "Yes" && review != "No")
                        {
                            Console.WriteLine("Please type a valid respons.");
                            satisfied = 0;
                        }
                        
                    } while (satisfied != 1);
                    
                }
                else if (input == "2")
                {
                    journal.ReadJournal();
                    journal.CalcAveQual();
                }
                else if (input == "3")
                {
                    Console.WriteLine("What would you like to be a new prompt?");
                    string newPrompt = Console.ReadLine();
                    prompt._prompts.Add(newPrompt);
                }
                else if (input == "0")
                {
                    Console.WriteLine("Have a nice day!");
                }
            } while (input != "0");
        }

        Menu();
    }
}