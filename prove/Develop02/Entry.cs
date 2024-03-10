using System;

namespace DailyJournal
{
    class Entry
    {
        // Properties for an entry
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        // Constructor for creating an entry
        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        // Override ToString method to format the entry when printing
        public override string ToString()
        {
            return $"{Date}\n{Prompt}\n{Response}\n";
        }
    }
}
