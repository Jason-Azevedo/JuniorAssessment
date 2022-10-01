// See https://aka.ms/new-console-template for more information
using JuniorAssessment;

try
{
    var bucket = new Bucket();

    /* Handle user input */
    Console.Write("Biscuits: ");
    bucket.BiscuitCount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Chewies: ");
    bucket.ChewieCount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Vitamins: ");
    bucket.VitaminCount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Bucket Size [Normal/Large]: ");
    bucket.Size = Console.ReadLine();

    // Validate bucket size input
    if (bucket.Size != "Normal" && bucket.Size != "Large")
    {
        Console.WriteLine("Bucket must be \"Normal\" or \"Large\".");
        return;
    }

    Console.Write("Weekend [Y/N]: ");
    bucket.IsWeekend = Console.ReadLine() == "Y" ? true : false;

    /* Display the total */
    var total = bucket.GetTotal();

    Console.WriteLine(total.ToString("0.##"));
}
catch (FormatException e)
{
    Console.WriteLine("\nInvalid input.");
}

