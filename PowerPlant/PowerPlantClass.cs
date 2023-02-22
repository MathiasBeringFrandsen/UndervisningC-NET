using System.ComponentModel;

namespace PowerPlant
{
    public class PowerPlantClass
    {
        private Warning warning;

        public void SetWarning(Warning warning) { 
            this.warning += warning;
        }

        public void HeatUp()
        {
            Random rand = new Random();
            if(rand.Next(101) > 50)
            {
                warning();
            }
        }
    }
}