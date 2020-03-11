namespace Lehmer
{
    public interface IRandom
    {
        int Next();
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        void NextBytes(byte[] buffer);
        double NextDouble();
        double NextDouble(double maxValue);
        double NextDouble(double minValue, double maxValue);
    }
}