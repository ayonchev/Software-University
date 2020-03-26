namespace Travel.Entities
{
	using System.Collections.Generic;
	using Contracts;

	/* 2/3
	 * You look so tired, unhappy
	 * Bring down the government
	 * They don't, they don't speak for us
	 */
	public class Passenger : IPassenger
	{
	    private List<IBag> bags;
		public Passenger(string username)
		{
			this.Username = username;

			this.bags = new List<IBag>();
		}

		public string Username { get; }

	    public IList<IBag> Bags => this.bags;
	}
}