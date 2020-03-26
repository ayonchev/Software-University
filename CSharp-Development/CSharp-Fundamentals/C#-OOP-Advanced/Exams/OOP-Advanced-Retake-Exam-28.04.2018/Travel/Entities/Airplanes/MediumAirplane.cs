namespace Travel.Entities.Airplanes
{
	public class MediumAirplane : Airplane
	{
	    private const int defaultCountSeats = 10;
	    private const int defaultCountBags = 14;
        public MediumAirplane()
			: base(defaultCountSeats, defaultCountBags)
		{
		}
	}
}