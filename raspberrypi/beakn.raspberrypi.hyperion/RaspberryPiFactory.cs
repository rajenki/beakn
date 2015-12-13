namespace Beakn.RaspberryPi
{
    public static class RaspberryPiFactory
    {
        public static IRaspberryPi Get()
        {
            return new RaspberryPiHyperion();
        }
    }
}
