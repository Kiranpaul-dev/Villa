namespace Villa.Logging
{
    public class Logging : ILogging
    { 
        public void Log(string message,string type) 
        {
            if (type == "error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("eRRoR  - "+message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine(message);
            }

        }
    }
}
