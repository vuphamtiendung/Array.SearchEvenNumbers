using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Input amount of the array");
        int amount = Convert.ToInt32(ReadLine());
        int[] array = new int[amount];
        WriteLine("Input the number in the array");
        for(int index = 0; index < amount; index++)
        {
            array[index] = Convert.ToInt32(ReadLine());
        }

        string _end = ReadLine();

        WriteLine("List of the array has number even");
        for(int index = 0; index < array.Length; index++)
        {
            if(array[index] % 2 == 0)
            {
                WriteLine($"- {array[index]}");
            }
            else
            {

            }
        }
        ReadLine();
    }
}