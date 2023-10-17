namespace ConsoleApp4.Documents
{
	abstract public class AbstractDocument
	{
		public int NumOfDoc { get; set; }
		public DateTime Date { get; set; }
		public string? Info { get; set; }

		public AbstractDocument(int num, DateTime date, string info)
		{
			this.NumOfDoc = num;
			this.Date = date;
			this.Info = info;
		}

		public override string ToString()
		{
			return $"{NumOfDoc}; {Date}; {Info};";
		}
	}
}
