using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BoatRacingSimulator.Utility;

namespace BoatRacingSimulator.Models
{
    using BoatRacingSimulator.Interfaces;

    public sealed class MotorBoat : IModelable
    {
        private string model;

        private int weight;

        private int oars;

        private int sailEfficiency;

        private int cargoWeight;

        public bool isSailboat;

        internal MotorBoat(string model, int weight, int sailEfficiency, int oars,int cargoWeight, IList<JetEngine> jetEngines, IList<SterndriveEngine> sterndriveEngines, bool isSailboat)
        {
            this.SailEfficiency = sailEfficiency;
            this.cargoWeight = cargoWeight;
            this.Oars = oars;
            this.model = model;
            this.Weight = weight;
            this.JetEngines = jetEngines;
            this.SterndriveEngines = sterndriveEngines;
            this.isSailboat = isSailboat;
        }

        IList<JetEngine> JetEngines { get; set; }

        IList<SterndriveEngine> SterndriveEngines { get; set; }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateModelLength(value, Constants.MinBoatModelLength);
                this.model = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                Validator.ValidatePropertyValue(value, "Weight");
                this.weight = value;
            }
        }

        public int Oars
        {
            get
            {
                return this.oars;
            }

            private set
            {
                Validator.ValidatePropertyValue(value, "Oars");
                this.oars = value;
            }
        }

        public int SailEfficiency
        {
            get
            {
                return this.sailEfficiency;
            }

            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException(Constants.IncorrectSailEfficiencyMessage);
                }

                this.sailEfficiency = value;
            }
        }

        public int CargoWeight
        {
            get
            {
                return this.cargoWeight;
            }

            private set
            {
                Validator.ValidatePropertyValue(value, "Cargo Weight");
                this.cargoWeight = value;
            }
        }

        public double CalculateRaceSpeed(IRace race)
        {
            if (this.JetEngines.Count + this.SterndriveEngines.Count == 2)
            {
                var speed = this.JetEngines.Sum(x=>x.Output) + this.SterndriveEngines.Sum(x=>x.Output) - this.Weight + (race.OceanCurrentSpeed / 5d);
                return speed;
            }
            else if (this.JetEngines.Count + this.SterndriveEngines.Count == 1)
            {
                var speed = this.JetEngines.Sum(x => x.Output) + this.SterndriveEngines.Sum(x => x.Output) - this.Weight - this.CargoWeight + (race.OceanCurrentSpeed / 2d);
                return speed;
            }          
            else if(isSailboat)
            {
                var speed = (race.WindSpeed * (this.SailEfficiency / 100d)) - this.Weight + (race.OceanCurrentSpeed / 2d);
                return speed;
            }
            else
            {
                var speed = (this.Oars * 100) - this.Weight + race.OceanCurrentSpeed;
                return speed;
            }
        }
    }
}
