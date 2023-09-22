string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0;
string message = "";

foreach (string value in values)
{
	decimal number;

	if (decimal.TryParse(value, out number))
	{
		total += number;
	}
	else
	{
		message += value;
	}
}

Console.WriteLine($"Message: {message} \nTotal: {total}");