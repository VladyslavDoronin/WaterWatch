namespace WaterWatch.Models
{
    public class WaterConsumption
    {

        public int Id { get; set; }
        public string Neighbourhood { get; set; } = default!;
        public string Suburb_group { get; set; } = default!;
        public int averageMonthlyKL{ get; set; }
        public string Coordinates { get; set; } = default!;
    }
}
