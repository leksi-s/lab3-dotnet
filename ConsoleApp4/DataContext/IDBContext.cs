using ConsoleApp4.Documents;

namespace ConsoleApp4.DataContext
{
	internal interface IDBContext
	{
		Letter CreateLetter();
		Command CreateCommand();
		OfficialMemo CreateMemo();
		Order CreateOrder();
		Statement CreateStatement();
	}
}
