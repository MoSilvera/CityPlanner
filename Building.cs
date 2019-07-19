using System;
namespace Planner
{
   public class Building {
       private string _designer = "Mo";
       private DateTime _dateConstructed {get; set;}
       private string _address { get; set;}

       private string _owner { get; set;}

       public int stories { get; set;}

       //you can manipulate the getter in any way you want, if you wanted to muliply it by two 
       public double volume {
           get{
               return width * depth * (3 * stories);
           }
           }
       public double depth { get; set;}

       private double _width;

// this sets a minimum value of 10 as the width, an exception will be thrown. 
       public double width { get {
           return width;
       }
       set{
           if (value > 10) {
               _width = value;
           }
       }}

        public Building (string inputAddress) {
            _address = inputAddress;
        }
        //Here if you changed the void to Building, and then said 'return this' at the end of the function, you could CHAIN methods. Because it returns itself, it is then available for more dot notation
        public void Construct () {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase (string buyerName) {
            _owner = buyerName;
        }

        public string GetAddress (){
            return _address;
        }
        public string GetDesigner () {
            return _designer;
        }
        public string GetOwner () {
            return _owner;
        }

        public DateTime GetBuildDate () {
            return _dateConstructed;
        }
   }
}