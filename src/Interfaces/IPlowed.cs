namespace Trestlebridge.Interfaces
{
    public interface IPlowed
    {
        double RowsPerDay { get; set; }
        void Plow();
    }
}