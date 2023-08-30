namespace AddRemoveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = new string[2] { "Rufat", "Nicat" };

            Console.WriteLine("Original Array:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Original Array Length: {nameList.Length}");

            Console.WriteLine("-------------------------------------------------");

            ArrayHelper.Add(ref nameList, "Vasif");
            ArrayHelper.Add(ref nameList, "Vusal");
            ArrayHelper.Add(ref nameList, "Elekber");

            Console.WriteLine("After Adding:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"After Adding Array Length: {nameList.Length}");

            Console.WriteLine("-------------------------------------------------");

            ArrayHelper.Remove(ref nameList, "Vasif");
            ArrayHelper.Remove(ref nameList, "Rufat");
            ArrayHelper.Remove(ref nameList, "Nicat");
            ArrayHelper.Remove(ref nameList, "Vusal");



            Console.WriteLine("After Removing:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"After Removing Array Length: {nameList.Length}");
        }
    }
}