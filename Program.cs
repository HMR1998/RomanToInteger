namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> romanToInegerDict = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 },
            };

            string romanValue = "XXVII";
            List<string> romanValueList = new List<string>();
            List<int> integerValueList = new List<int>();

            for (int i = 0; i < romanValue.Length; i++) 
            {
                romanValueList.Add(romanValue[i].ToString());
            }

            foreach (string value in romanValueList)
            {
                value.ToString();
                int intValue = romanToInegerDict[value];
                integerValueList.Add(intValue);
            }


        }
    }
}
