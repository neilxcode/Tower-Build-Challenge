// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;


// Write a function that takes in a number as an input
// It should return a tower of *. The tower will be an array of strings.
// The number passed in tells you how many floors it should have.
// Expectation: First floor 1 star, Second floor 3 stars, Third floor 5 stars

// What to figure out:
// What calculation determines how many blocks should be in the next floor?
// Answer: previous amount of blocks + 2

// What calculation determines how many spaces before * is returned?
// Answer:  Count of blocks in last floor - blocks in current floor / 2

public class Kata
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        int floorCount = 10;
        TowerBuild(floorCount);
    }
    public static string[] TowerBuild(int nFloors)
    {

        int blockCount = 1;
        List<string> starTower = new List<string>();
        //For each floor, where nFloors is the amount of floors
        for (int i = 1; i <= nFloors; i++)
        {
            //Determine amount of blocks
            if (i > 1)
            {
                blockCount += 2;
                //Console.WriteLine(blockCount);
            }
            //Determine max block count
            int maxCount = (nFloors * 2) - 1;

            //Determine amount of spaces
            int spaceCount = (maxCount - blockCount) / 2;

            //Console.WriteLine("Test");
            //.WriteLine("Space Count :" + spaceCount);

            //Create string
            string currentFloor = "";
            currentFloor += new string(' ', spaceCount);
            currentFloor += new string('*', blockCount);
            currentFloor += new string(' ', spaceCount);
            Console.WriteLine(currentFloor);

            //Add floor to list
            starTower.Add(currentFloor);

        }
        String[] starTowerArray = starTower.ToArray();
        return starTowerArray;
    }
}
