public class Journal() {
    public static List<Entry> _entries = new List<Entry>();
    DateTime _startDate = DateTime.Now;

    public void Display() {
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }

    public void AddEntry(Entry entry){
        Journal._entries.Add(entry);
    }

    public void SaveToFile(String filename) {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in Journal._entries)
                    {
                        // needs to write each entry in date, prompt, mood, response format
                        String date = entry._date;
                        String prompt = entry._prompt;
                        String response = entry._response;
                        String mood = entry._mood;
                        outputFile.WriteLine($"{date},{prompt},{mood},{response}");
                    }
                }
    }

    public void LoadFromFile(String filename){
        String[] lines = System.IO.File.ReadAllLines(filename);
        Journal._entries.Clear();

        foreach (String line in lines){
            Entry newEntry = new Entry();
            String[] parts = line.Split(",");

            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._mood = parts[2];
            newEntry._response = parts[3];

            Journal._entries.Add(newEntry);
        }
    }
}