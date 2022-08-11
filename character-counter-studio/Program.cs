namespace character_counter_studio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:/Users/Naps/Documents/launchcode/c-sharp/shortname.txt";
            //string userString = File.ReadAllText(path);
            //string loremPrime = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> CharCount = new Dictionary<char, int>();
            Console.WriteLine("Enter a string, or sentence: ");
            string userString = Console.ReadLine().ToLower();

            foreach (char c in userString)
            {
                if (char.IsLetter(c))
                {
                    if (!CharCount.ContainsKey(c))
                    {
                        CharCount.Add(c, 1);
                    }
                    else
                    {
                        CharCount[c]++;
                    }
                }
            }
            foreach (KeyValuePair<char, int> kvp in CharCount) 
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}