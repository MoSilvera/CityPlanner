using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
          Building FiveOneTwoEigth = new Building("512 8th Avenue"){
              width = 100.00,
              depth = 100.00,
              stories = 100,
          };

          FiveOneTwoEigth.Construct();
          FiveOneTwoEigth.Purchase("Mary Mc Maryface");

          Building TwoTwoTwo = new Building("222 pleasant drive"){
              width = 1000.00,
              depth = 1000.00,
              stories = 1000,
          };

          TwoTwoTwo.Construct();
          TwoTwoTwo.Purchase("Mary Mc Mac");

          Building ThreeThreeThree = new Building("333 3rd Avenue"){
              width = 10000.00,
              depth = 10000.00,
              stories = 10000,
          };

          ThreeThreeThree.Construct();
          ThreeThreeThree.Purchase("Mary Mc Mary");

        List <Building> myBuildings = new List<Building>() {
            FiveOneTwoEigth,
            TwoTwoTwo,
            ThreeThreeThree
        };

        City giantTown = new City("Giant Town");
        giantTown.addBuilding(TwoTwoTwo);
        giantTown.addBuilding(ThreeThreeThree);
        giantTown.addBuilding(FiveOneTwoEigth);

        foreach (Building oneBuilding in giantTown.currentBuildings)
        {
          Console.WriteLine($@"
{oneBuilding.GetAddress()}
Designed by: {oneBuilding.GetDesigner()}
Constructed on: {oneBuilding.GetBuildDate()}
Owned by: {oneBuilding.GetOwner()}
{oneBuilding.volume} cubic meters of space
        ");

        }
    }
} }
