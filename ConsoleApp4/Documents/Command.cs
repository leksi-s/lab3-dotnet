namespace ConsoleApp4.Documents
{
	internal class Command : Order
	{
		public string? Responsible { get; set; }
		public Command(int num, DateTime date, string info, int unit, DateTime deadline, string responsible)
					  : base(num, date, info, unit, deadline)
		{
			this.Responsible = responsible;
		}
		public override string ToString()
		{
			return base.ToString() + $"{Responsible};";
		}
	}
}
