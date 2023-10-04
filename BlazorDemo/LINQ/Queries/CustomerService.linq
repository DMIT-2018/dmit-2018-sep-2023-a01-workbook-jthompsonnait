<Query Kind="Program">
  <Connection>
    <ID>c2e59a04-ac57-4d03-9ee7-b7b41891dc7e</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>OLTP-DMIT2018</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

//	the following is equivalent to using in c#
//	the load method allows for us to reference the view models.
#load "..\ViewModels\*.cs"
#load "..\Queries\CustomerService.linq"


void Main()
{

	
}

/// <summary>
/// Retrieves a list of customers based on the provided search criteria.
/// </summary>
/// <param name="lastName">The last name of the customer to search for.</param>
/// <param name="phone">The phone number of the customer to search for</param>
/// <returns>A list of <see cref="CustomerSearchView"/> objects that match the 
/// 	provided search criteria. Returns a null exception if nothing is return.</returns>
public List<CustomerSearchView> GetCustomers(string lastName, string phone)
{
	#region Business Logic and Parameter Exception
	//	create a List<Exception> to conatin all discoverd errors
	List<Exception> errorList = new List<Exception>();
	//	Business Rules (all business rules are listed here)
	//		rule: both last name and phone number cannot be empty
	//		rule: if both values are provided
	//				both values will be used in returning
	//				a list of customer search views
	//		rule:	RemoveFromViewFlag must be false

	//	parameter validation

	#endregion

	/*
		actual code for method
	*/
	if (errorList.Count() > 0)
	{
		throw new AggregateException("Unable to proceed!  Check concerns", errorList);
	}

	//	NOTE: we return a "null" so that the application does not throw an exception
	//			"not al code paths return a value"
	return null;
}