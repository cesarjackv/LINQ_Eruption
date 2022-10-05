List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
//PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

//  1.
Console.WriteLine("1.");
Console.WriteLine(eruptions.FirstOrDefault(a => a.Location == "Chile"));

//  2.
Console.WriteLine("2.");
if(eruptions.Where(a => a.Location == "Hawaiian Is") != null){
    Console.WriteLine(eruptions.FirstOrDefault(a => a.Location == "Hawaiian Is"));
}else{
    Console.WriteLine("No Hawaiian Is Eruption Found");
}

//  3.
Console.WriteLine("3.");
Console.WriteLine(eruptions.FirstOrDefault(a => a.Location == "New Zealand" && a.Year >= 1900));


//  4.
Console.WriteLine("4.");
IEnumerable<Eruption> ElevationOver2000 = eruptions.Where(a => a.ElevationInMeters > 2000);
PrintEach(ElevationOver2000);

//  5.
Console.WriteLine("5.");
IEnumerable<Eruption> Volcano_w_L = eruptions.Where(a => a.Volcano[0] == 'L');
PrintEach(Volcano_w_L);
Console.WriteLine(eruptions.Count(a => a.Volcano[0] == 'L'));


//  6.
Console.WriteLine("\n6.\n");
Console.WriteLine(eruptions.Max(a => a.ElevationInMeters));


//  7.
Console.WriteLine("\n7.");
IEnumerable<Eruption> Num = eruptions.Where(a => a.ElevationInMeters == eruptions.Max(a => a.ElevationInMeters));
PrintEach(Num.Select(a => a.Volcano));


//  8.
Console.WriteLine("\n8.");
IEnumerable<Eruption> AlphabetVolcano = eruptions.OrderByDescending(a => a.Volcano);
PrintEach(AlphabetVolcano);


//  9.
Console.WriteLine("9.");
PrintEach(AlphabetVolcano.Where(a => a.Year < 1000));

Console.WriteLine();


//  10.
Console.WriteLine("10. ( Bonus )");
IEnumerable<Eruption> VolNames = AlphabetVolcano.Where(a => a.Year < 1000);
PrintEach(VolNames.Select(a => a.Volcano));


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}