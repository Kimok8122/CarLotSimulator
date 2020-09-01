using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        public string Year { set; get; }
        public string Make { set; get; }
        public string Model { set; get; }
        public string EngineNoise { set; get; }
        public string HonkNoise { set; get; }
        public string IsDrive { set; get; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property 

        public void MakeEngineNoise()
        {
            return 
        }

        public void MakeHonkNoise()
        {

        }


    }
}
}
