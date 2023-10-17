namespace ConsoleApp4.Documents
{
	internal class Statement : AbstractDocument
	{
		public string? Employee { get; set; }
		public string? Resources { get; set; }
		public Statement(int num, DateTime date, string info, string employee, string resources)
					  : base(num, date, info)
		{
			this.Employee = employee;
			this.Resources = resources;
		}
		public override string ToString()
		{
			return base.ToString() + $"{Employee}; {Resources};";
		}
	}
}
