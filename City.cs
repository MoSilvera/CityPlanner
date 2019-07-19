using System;
using System.Collections.Generic;

namespace Planner {

    public class City {
        public List<Building> currentBuildings {get; set;} = new List<Building>();

        private string _Name {get; set;}

        private int _cityCreated {get; set;}

        public string Mayor {get; set;}
        public City(string name){
            _Name = name;
            }
        public void electMayor (string mayor)
        {
            Mayor = mayor;
        }

        public string getCityName() {
            return _Name;
        }

        public void yearEstablished (int year)
        {
            _cityCreated = year;
        }

        public int getCityCreationDate() {
            return _cityCreated;
        }

        public int Size {get; set;}

        public string Address {get; set;}

        public void addBuilding (Building building){
            currentBuildings.Add(building);
        }


    }

}