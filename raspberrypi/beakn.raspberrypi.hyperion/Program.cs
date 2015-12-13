namespace Beakn.RaspberryPi
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpi = RaspberryPiFactory.Get();

            var mqtt = new Mqtt(rpi);
            mqtt.Setup();
        }
    }
}
