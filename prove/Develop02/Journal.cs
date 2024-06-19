public class Journal() {
    public List<Entry> _entries = new List<Entry>();
    static String _owner = "";
    DateTime _startDate = DateTime.Now;

    public void Display() {
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }
}