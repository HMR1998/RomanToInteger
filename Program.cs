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

            string romanValue = "XXIV";
            List<string> romanValueList = new List<string>();
            List<int> integerValueList = new List<int>();

            for (int value = 0; value < romanValue.Length; value++) 
            {
                romanValueList.Add(romanValue[value].ToString());

            }

            foreach (string value in romanValueList)
            {
                value.ToString();
                int intValue = romanToInegerDict[value];
                integerValueList.Add(intValue);
            }

            for(int i = 0; i < integerValueList.Count - 1; i++)
            {
                int leftVal = integerValueList[i];
                int rightVal = integerValueList[i + 1];

                if (leftVal < rightVal)
                {
                    int updatedVal = rightVal - leftVal;
                    integerValueList.Add((int) updatedVal);
                    integerValueList.Remove(leftVal);
                    integerValueList.Remove(rightVal);
                }
            }
            int total = integerValueList.Sum(x => x);
            Console.WriteLine(total);

        }
    }
}
