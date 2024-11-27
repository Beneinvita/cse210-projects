using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.WriteNewEntry();
                        break;
                    case "2":
                        journal.DisplayJournal();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Prompt: {Prompt}");
            Console.WriteLine($"Response: {Response}");
            Console.WriteLine();
        }
    }

    class Journal
    {
        private List<Entry> _entries = new List<Entry>();
        private List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        public void WriteNewEntry()
        {
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];

            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();

            string date = DateTime.Now.ToShortDateString();
            _entries.Add(new Entry(date, prompt, response));

            Console.WriteLine("Entry added successfully!");
        }

        public void DisplayJournal()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("\nNo entries in the journal.");
            }
            else
            {
                Console.WriteLine("\nJournal Entries:");
                foreach (Entry entry in _entries)
                {
                    entry.Display();
                }
            }
        }

        public void SaveToFile()
        {
            Console.Write("\nEnter the filename to save the journal: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved successfully!");
        }

        public void LoadFromFile()
        {
            Console.Write("\nEnter the filename to load the journal: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found. Please try again.");
                return;
            }

            _entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
    }
}
    // Addinational creativity added as follows 
    // Randomly select a prompt from the list to make the journaling experience varied and engaging.
// Validate numeric input for menu choice to prevent errors and provide clear feedback to the user.
// Handle errors gracefully when attempting to load from a file that does not exist.
// The Journal class manages all entries, adhering to the principle of abstraction.
// Save all entries in the journal to a specified file, separating data with '|'.
// Inform the user if no entries are available to display.