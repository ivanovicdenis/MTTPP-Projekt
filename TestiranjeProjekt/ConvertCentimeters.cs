

namespace TestiranjeProjekt
{
    class ConvertCentimeters
    {
        public double CentimeterToMeter(double centimeters)
        {
            return centimeters / 100;
        }
        public double CentimeterToKilometer(double centimeters)
        {
            return centimeters / 100000;
        }
        public double CentimeterToMilimeter(double centimeters)
        {
            return centimeters * 10;
        }
        public double CentimeterToMicrometer(double centimeters)
        {
            return centimeters * 10000;
        }
        public double CentimeterToNanometer(double centimeters)
        {
            return centimeters * 10000000;
        }
        public double CentimeterToMile(double centimeters)
        {
            return centimeters * 0.0000062137;
        }
        public double CentimeterToYard(double centimeters)
        {
            return centimeters * 0.010936133;
        }
        public double CentimeterToFoot(double centimeters)
        {
            return centimeters * 0.032808399;
        }
        public double CentimeterToInch(double centimeters)
        {
            return centimeters * 0.3937007874;
        }
        public double CentimeterToLightYear(double centimeters)
        {
            return (centimeters/1000000000000) * 0.000001057;
        }

    }
}
