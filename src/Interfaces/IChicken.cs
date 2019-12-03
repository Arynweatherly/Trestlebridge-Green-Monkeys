namespace Trestlebridge.Interfaces
{
    public interface IChicken
    {
        double FeedPerDay { get; set; }
        void Feed();
        void RefillFeeder()
        {
            FeedLevel = 100;
        }
        int FeedLevel { get; set; }
        void EggGather();

        void FeatherHarvester();
    }
}