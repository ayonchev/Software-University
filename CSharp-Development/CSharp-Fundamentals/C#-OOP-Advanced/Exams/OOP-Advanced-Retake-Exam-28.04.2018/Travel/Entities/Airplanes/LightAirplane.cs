namespace Travel.Entities.Airplanes
{
	public class LightAirplane : Airplane
	{
	    private const int defaultCountSeats = 5;
	    private const int defaultCountBags = 8;
		public LightAirplane()
			: base(defaultCountSeats, defaultCountBags)
		{
		}
	}
}