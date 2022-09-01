namespace BasicMVCApp.Models
{
	public class Supplier : Entity
	{
		public enum SupplierType
		{
			PhysicalPerson = 1,
			LegalPerson = 2
		}
		public string Name { get; set; }
		public string Document { get; set; }
		public SupplierType Type { get; set; }
		public Address Address { get; set; }
		public bool Active { get; set; }

		public IEnumerable<Product> Produtos { get; set; }
	}
}
