using System.Runtime.InteropServices.JavaScript;

namespace MyNamespace
{
    class VowelCounter
    {
        public string input { get; set; }
        
        
        public VowelCounter(string input)
        {
            this.input = input;
        }

        public int getVowelCount()
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u'};
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}

