<Query Kind="Program" />

void Main()
{
	Test_Math_Division_IsValid();
}

//	validate that the division function
//		returns a correct value
public void Test_Math_Division_IsValid()
{
	//	Arrange
	//	Initialize any variable for our test
	decimal num1 = 10;
	decimal num2 = 2;
	
	//	Act
	//	Only the call to the method/function you are testing.
	//	Rename result to actual for camparing
	var actual = Div(num1, num2);

	//	Assert
	//	Verify that the outcome of the "Act" phase matches
	//		the expected result or behaviour.
	//	NOTE:	We set the expected result to 7 to force
	//				a failure.
	decimal expected = 7;

	//	Validate if we got the expected results.
	string isValid = actual == expected ? "Pass" : "Fail";

	//	Display the result to the user
	Console.WriteLine($"-- {isValid} -- Test_Math_Division_IsValid: Expected {expected} vs Actual {actual}");
}

//	Math method for return a number that when 2 numbers
//		are divide by each other.
public decimal Div(decimal num1, decimal num2)
{
	return num1 / num2;
}