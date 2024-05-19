namespace BoatRacingSimulator.Models
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    internal abstract class engine
    {


        public abstract int Output { get; }
    }

    class JetEngine : engine, IModelable
    {
        private const int Multiplier = 5;

        private string model;

        private int horsepower;

        private int displacement;

        public JetEngine(string model, int horsepower, int displacement)
        {
            this.Model = model;
            this.Horsepower = horsepower;
            this.Displacement = displacement;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateModelLength(value, Constants.MinBoatEngineModelLength);
                this.model = value;
            }
        }

        public override int Output
        {
            get
            {
                if (this.CachedOutput != 0)
                {
                    return this.CachedOutput;
                }

                this.CachedOutput = (this.Horsepower * Multiplier) + this.Displacement;
                return this.CachedOutput;
            }
        }

        protected int CachedOutput { get; set; }

        protected int Horsepower
        {
            get
            {
                return this.horsepower;
            }

            set
            {
                Validator.ValidatePropertyValue(value, "Horsepower");
                this.horsepower = value;
            }
        }

        protected int Displacement
        {
            get
            {
                return this.displacement;
            }

            set
            {
                Validator.ValidatePropertyValue(value, "Displacement");
                this.displacement = value;
            }
        }
    }

    class SterndriveEngine : engine, IModelable
    {
        private const int Multiplier = 7;

        private string model;

        private int horsepower;

        private int displacement;

        public SterndriveEngine(string model, int horsepower, int displacement)
        {
            this.Model = model;
            this.Horsepower = horsepower;
            this.Displacement = displacement;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateModelLength(value, Constants.MinBoatEngineModelLength);
                this.model = value;
            }
        }

        public override int Output
        {
            get
            {
                if (this.CachedOutput != 0)
                {
                    return this.CachedOutput;
                }

                this.CachedOutput = (this.Horsepower * Multiplier) + this.Displacement;
                return this.CachedOutput;
            }
        }

        protected int CachedOutput { get; set; }

        protected int Horsepower
        {
            get
            {
                return this.horsepower;
            }

            set
            {
                Validator.ValidatePropertyValue(value, "Horsepower");
                this.horsepower = value;
            }
        }

        protected int Displacement
        {
            get
            {
                return this.displacement;
            }

            set
            {
                Validator.ValidatePropertyValue(value, "Displacement");
                this.displacement = value;
            }
        }
    }
}
