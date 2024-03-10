using System;
using System.Collections.Generic;
using System.IO;

namespace DailyJournal
{
    class Journal
    {
        // List to store journal entries
        private List<Entry> entries;

        // Constructor to initialize the list
        public Journal()
        {
            entries = new List<Entry>();
        }

        // Method to add a new entry to the journal
        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        // Method to display all entries in the journal
        public void DisplayEntries()
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        // Method to save journal entries to a file
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry);
                }
            }
        }

        // Method to load journal entries from a file
        public void LoadFromFile(string fileName)
        {
            entries.Clear(); // Clear existing entries
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string prompt = line;
                    string response = reader.ReadLine();
                    string date = reader.ReadLine();
                    entries.Add(new Entry(prompt, response, date));
                }
            }
        }
    }
}
