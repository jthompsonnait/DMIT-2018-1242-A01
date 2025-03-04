<Query Kind="Program">
  <Connection>
    <ID>86bdf9e1-7f71-4cbc-a54b-f58c14f9615b</ID>
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

void Main()
{
	GetCustomers("Fo", "").Dump();	
}


public List<CustomerSearchView> GetCustomers(string lastName, string phone)
{
	//  Business Rules
	//    These are processing rules that need to be satisfied
	//        for valid data

	// 	rule:	Both last name and phone number cannot be empty
	// 	rule:	RemoveFromViewFlag must be false
	if (string.IsNullOrEmpty(lastName) && string.IsNullOrWhiteSpace(phone))
	{
		throw new ArgumentNullException("Please provide either a last name and/or phone number");
	}

	//	Need to update parameters so we are not searching on n empty value.
	//	Otherwise, an empty string will return all records
	if (string.IsNullOrWhiteSpace(lastName))
	{
		lastName = Guid.NewGuid().ToString();
	}
	if (string.IsNullOrWhiteSpace(phone))
	{
		phone = Guid.NewGuid().ToString();
	}

	// return customers that meet our criteria
	return Customers
			.Where(x => x.LastName.Contains(lastName)
					|| x.Phone.Contains(phone)
					&& !x.RemoveFromViewFlag)
			.Select(x => new CustomerSearchView
			{
				CustomerID = x.CustomerID,
				FirstName = x.FirstName,
				LastName = x.LastName,
				City = x.City,
				Phone = x.Phone,
				Email = x.Email,
				StatusID = x.StatusID,
				TotalSales = x.Invoices.Sum(x => x.SubTotal + x.Tax)
			})
			.OrderBy(x => x.LastName)
			.ToList();
}

public class CustomerSearchView
{
	/// <summary>
	/// Gets or sets the customer identifier.
	/// </summary>
	/// <value>The customer identifier.</value>
	public int CustomerID { get; set; }
	/// <summary>
	/// Gets or sets the first name.
	/// </summary>
	/// <value>The first name.</value>
	public string FirstName { get; set; }
	/// <summary>
	/// Gets or sets the last name.
	/// </summary>
	/// <value>The last name.</value>
	public string LastName { get; set; }
	/// <summary>
	/// Gets or sets the city.
	/// </summary>
	/// <value>The city.</value>
	public string City { get; set; }
	/// <summary>
	/// Gets or sets the phone.
	/// </summary>
	/// <value>The phone.</value>
	public string Phone { get; set; }
	/// <summary>
	/// Gets or sets the email.
	/// </summary>
	/// <value>The email.</value>
	public string Email { get; set; }
	/// <summary>
	/// Gets or sets the status identifier.
	/// </summary>
	/// <value>The status identifier.</value>
	public int StatusID { get; set; }
	/// <summary>
	/// Gets or sets the total sales.
	/// </summary>
	/// <value>The total sales.</value>
	public decimal? TotalSales { get; set; }
}

