using BoatRacingSimulator.Models;

namespace BoatRacingSimulator.Database
{
    using BoatRacingSimulator.Interfaces;

    public class BoatSimulatorDatabase
    {
        public BoatSimulatorDatabase()
        {
            this.Boats = new Repository<MotorBoat>();
            this.Engines = new Repository<IModelable>();
        }

        public IRepository<MotorBoat> Boats { get; private set; }

        public IRepository<IModelable> Engines { get; private set; }
    }
}
