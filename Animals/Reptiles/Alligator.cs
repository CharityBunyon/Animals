using System;
using System.Collections.Generic;
using System.Text;


namespace Animals.Reptiles
{
    class Alligator
        //internal before class means: I am only accessible inside of this project
    {
        public bool IsAquatic
        { get; set;
            //these are called auto property(terse code)
        }
        //this is called an auto property

        private int _stepGoal;
        private int _stepCount;
        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }
        internal void Grunt()
        {
            if(IsAquatic)
            {
                Console.WriteLine("Bubble Bubble");
            }
            else
            {
                Console.WriteLine("GRRRR!");
            }
        }

        public void Run(int steps)
        {
            _stepCount += steps;
            Console.WriteLine($"You ran {steps} steps!");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("Congrats, you met your goal!");
            }
        }
    }
}
