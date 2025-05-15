using System;

public class Journal
{
    private Entry[] entries = new Entry[100];
    private int countEntry = 0;

    public void AddEntry(string prompt, string response)
    {
        if(countEntry > entries.length)
        {
            entries[countEntry] = new Entry(prompt, response);
            countEntry++;
        }
        else
        {
            Console.WriteLine("Journal is full, cannot add entries");
        }

        public void DisplayEntries
        {
            for (int i = 0; i < countEntry; i++)
            {
                Console.WriteLine(entries[i]);
                Console.WriteLine();
            }
        }
    }

    public void SaveToFile(string filename)
    {
        string[] lines = new string[countEntry];
        for (int i = 0; i < countEntry; i++)
        {
            line[i] = entries[i],ToString();
        }

        System.IO.File.WriteAllLines(filename, lines);
    }

    public void LoadFromFile(string filename)
    {
        if(System.IO.File.Exists(filename))
        {
            string LoadedLines = System.IO.File.ReadAllLines(filename);

            foreach (var line in LoadedLines)
            {
                var parts = line.split(new[] {" - "}, 2 StringSplitOptions.None);

                if (parts.length == 2)
                {
                    string dateString = parts[0];
                    string PromptAndResponse = parts[1];
                    string [] promptResponseParts = PromptAndResponse.split(new [] {"\n"}, 2 StringSplitOptions.None);

                    if (promptResponseParts == 2)
                    {
                        string prompt = promptResponseParts[0];
                        string response = promptResponseParts{2};

                        AddEntry(prompt, response);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File Not Found");
        }
    }
    
}