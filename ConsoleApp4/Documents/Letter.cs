namespace ConsoleApp4.Documents
{
	internal class Letter : AbstractDocument
	{
		public string? Sender { get; set; }
		public string? Receiver { get; set; }

		public Letter(int num, DateTime date, string info, string sender, string receiver)
					  : base(num, date, info)
		{
			this.Sender = sender;
			this.Receiver = receiver;
		}

		public override string ToString()
		{
			return base.ToString() + $"{Sender}; {Receiver};";
		}
	}
}
