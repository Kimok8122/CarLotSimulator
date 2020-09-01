using System;
namespace CarLotSimulator
{
    public class Car
    {
   
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        public double Year { set; get; }
        public string Make { set; get; }
        public string Model { set; get; }
        public string EngineNoise { set; get; }
        public string HonkNoise { set; get; }
        public string IsDriveable { set; get; }

       

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property 

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{Model} engine sounds like {EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"{Model} horn sounds like {HonkNoise}");
        }

      


    }
}

