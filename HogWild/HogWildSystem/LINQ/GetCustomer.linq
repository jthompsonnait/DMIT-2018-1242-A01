<Query Kind="Program">
  <Connection>
    <ID>7feab626-14df-4634-b90d-faf30c4fafbb</ID>
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
	GetCustomer(0).Dump();
}

public CustomerEditView GetCustomer(int customerID)
{
	//  Business Rules
	//	These are processing rules that need to be satisfied
	//		for valid data
	//		rule:	customerID must be valid 

	if (customerID == 0)
	{
		throw new ArgumentNullException("Please provide a customer");
	}

	return Customers
		.Where(x => (x.CustomerID == customerID
					 && x.RemoveFromViewFlag == false))
		.Select(x => new CustomerEditView
		{
			CustomerID = x.CustomerID,
			FirstName = x.FirstName,
			LastName = x.LastName,
			Address1 = x.Address1,
			Address2 = x.Address2,
			City = x.City,
			ProvStateID = x.ProvStateID,
			CountryID = x.CountryID,
			PostalCode = x.PostalCode,
			Phone = x.Phone,
			Email = x.Email,
			StatusID = x.StatusID,
			RemoveFromViewFlag = x.RemoveFromViewFlag
		}).FirstOrDefault();
}

public class CustomerEditView
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
	/// Gets or sets the address1.
	/// </summary>
	/// <value>The address1.</value>
	public string Address1 { get; set; }
	/// <summary>
	/// Gets or sets the address2.
	/// </summary>
	/// <value>The address2.</value>
	public string Address2 { get; set; }
	/// <summary>
	/// Gets or sets the city.
	/// </summary>
	/// <value>The city.</value>
	public string City { get; set; }
	/// <summary>
	/// Gets or sets the prov state identifier.
	/// </summary>
	/// <value>The prov state identifier.</value>
	public int ProvStateID { get; set; }
	/// <summary>
	/// Gets or sets the country identifier.
	/// </summary>
	/// <value>The country identifier.</value>
	public int CountryID { get; set; }
	/// <summary>
	/// Gets or sets the postal code.
	/// </summary>
	/// <value>The postal code.</value>
	public string PostalCode { get; set; }
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
	/// Gets or sets a value indicating whether [remove from view flag].
	/// </summary>
	/// <value><c>true</c> if [remove from view flag]; otherwise, <c>false</c>.</value>
	public bool RemoveFromViewFlag { get; set; }
}
