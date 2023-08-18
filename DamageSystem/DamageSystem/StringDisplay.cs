namespace DamageSystem
{
    public class StringDisplay : IDisplay
    {
        private readonly List<string> lines = new();

        public void WriteLine(string line)
        {
            lines.Add(line);
        }

        public string[] GetLines()
        {
            return lines.ToArray();
        }
    }
}