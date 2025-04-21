namespace CyberSecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayAsciiArt("files/AsciiArt.txt");
        }

        static void DisplayAsciiArt(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(File.ReadAllText(filePath));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: ASCII file not found at path: {filePath}");
                Console.ResetColor();
            }
        }
    }
}
