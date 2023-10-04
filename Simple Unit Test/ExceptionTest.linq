<Query Kind="Program">
  <Connection>
    <ID>544742c2-956f-4ff6-965a-61ab55d5434e</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>ChinookSept2018</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

void Main()
{
	try
	{
		//	passing an invalid track ID (less than 1)
		ExceptionTest(0);
	}
	#region catch all exceptions
	catch (AggregateException ex)
	{
		foreach (var error in ex.InnerExceptions)
		{
			error.Message.Dump();
		}
	}
	catch (ArgumentNullException ex)
	{
		GetInnerException(ex).Message.Dump();
	}
	catch (Exception ex)
	{
		GetInnerException(ex).Message.Dump();
	}
	#endregion
}

/// <summary>
/// Retrieves the innermost exception from a given exception.
/// </summary>
/// <param name="ex">The exception from which to extract the innermost exception.</param>
/// <returns>The innermost exception, or the original exception if it has no inner exceptions.</returns>
private Exception GetInnerException(Exception ex)
{
	while (ex.InnerException != null)
		ex = ex.InnerException;
	return ex;
}


public void ExceptionTest(int trackID)
{
	#region Business Logic and parameter exception
	//	create a List<Exception> to contain all discovered errors
	List<Exception> errorList = new List<Exception>();
	//	Business Rules
	//		rule:	Track ID must be valid

	//	parameter validation

	if (trackID <1)
	{
		throw new Exception($"TrackID is invalid");
	}

	#endregion

	/*
		actual code for method.
	*/

	if (errorList.Count() > 0)
	{
		//	throw the list of business processing error(s)
		throw new AggregateException("Unable to process! Check concerns", errorList);
	}
}


// You can define other methods, fields, classes and namespaces here