namespace SOLID.SRP
{
    public class Journal
    {
        private readonly List<string> Entries = new List<string>();

        private static int count = 0;


        public int AddEntry(string entry)
        {
            Entries.Add($"{++count}: {entry}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            Entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Entries);
        }

        //The class will be doing too much which could result in multiple reasons for it to change 
        // public void Save(string filename){
        //     File.WriteAllText(filename, ToString());
        // }

    }
    //this class creates a seperation of concerns
    public class Persistence
    {
        public void SaveToFIle(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || File.Exists(filename))
                File.WriteAllText(filename, j.ToString());
        }
    }
}