using System.Diagnostics;

namespace Beakn.RaspberryPi
{
    public class RaspberryPiHyperion : IRaspberryPi
    {
        public void Set(string presence)
        {
            var hyperionParams = "";

            switch (presence)
            {
                case "DoNotDisturb":
                case "Busy":
                    hyperionParams = "-c red";
                    break;
                case "TemporarilyAway":
                case "Away":
                    hyperionParams = "-c yellow";
                    break;
                case "Free":
                    hyperionParams = "-c green";
                    break;
                default:
                    return;
            }

            Process.Start("/usr/bin/hyperion-remote", hyperionParams);
        }
    }
}
