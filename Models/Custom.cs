namespace ef_core.Models;

public class Custom
{
	public int Id { get; set; }
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string? Address { get; set; }
	public string? Phone { get; set; }

	public ICollection<Order> Orders { get; set; } = null!;


}