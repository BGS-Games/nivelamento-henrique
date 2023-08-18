namespace DamageSystem
{
    public class ConsoleDisplay : IDisplay
    {
        public ConsoleDisplay()
        {
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}