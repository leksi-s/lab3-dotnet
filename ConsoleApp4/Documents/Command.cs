namespace ConsoleApp4.Documents
{
	internal class Command : AbstractDocument
	{
		public int Unit { get; set; }
		public DateTime Deadline { get; set; }
		public string? Responsible { get; set; }
		public Command(int num, DateTime date, string info, int unit, DateTime deadline, string responsible)
					  : base(num, date, info)
		{
			this.Unit = unit;
			this.Deadline = deadline;
			this.Responsible = responsible;
		}
		public override string ToString()
		{
			return base.ToString() + $"{Responsible};";
		}
	}
}
