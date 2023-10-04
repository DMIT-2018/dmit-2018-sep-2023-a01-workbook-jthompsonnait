<Query Kind="Program" />

void Main()
{
	decimal num1 = 6;
	decimal num2 = 5;
	var result = Div(num1, num2);
	result.Dump();
}

public decimal Div(decimal a, decimal b)
{
	return a / b;
}

// You can define other methods, fields, classes and namespaces here