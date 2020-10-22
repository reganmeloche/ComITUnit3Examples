using System;

namespace Unit3Examples
{
    /*
    Challenge: Implement the Fire() and TakeDamage() methods. 
    You will need to decide which new data members will be required and add them in. 
    Complete the 3 constructors
    */
    public class Hero
    {
        /*** Constructors ***/
        // 1. Empty Constructor - set default values for all data
        Hero();
        // 2. Constructor that only takes in an argument for the name. Set others to reasonable defaults
        Hero(string nameArg) {
            Name = nameArg;
            isFlying = false; 
        }

        // 3. Constructor that takes in arguments for all data
        Hero(string name, bool isFlying,string status){
            Name = name;
            isFlying = isFlying;
            Status = status;
        }

        /*** Data Members ***/
        public string Name { get; set; }
        private bool isFlying;
        private string  Status; 


        /*** Methods ****/
        public void Fire() {
            // Note: Can only fire if not flying
            if(!isFlying){
                Console.WriteLine($"{Name} can fly!");
        }

        public void TakeDamage() {
            if(Status=="Damage"){
                Console.WriteLine($"{Name} is damaged!");
            }
        }

        public void StartFlying() {
            if (!isFlying) {
                isFlying = true;
                Console.WriteLine($"{Name} starts flying!");
            }
        }

        public void Land() {
            if (isFlying) {
                isFlying = false;
                Console.WriteLine($"{Name} has landed!");
            }
        }
    
    }
}
