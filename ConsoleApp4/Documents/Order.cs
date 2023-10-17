namespace ConsoleApp4.Documents
{
	internal class Order : AbstractDocument
	{
		public int Unit { get; set; }
		public DateTime Deadline { get; set; }

		public Order(int num, DateTime date, string info, int unit, DateTime deadline)
					  : base(num, date, info)
		{
			this.Unit = unit;
			this.Deadline = deadline;
		}

		public override string ToString()
		{
			return base.ToString() + $"{Unit}; {Deadline};";
		}
	}
}
