using System.ComponentModel.DataAnnotations;

namespace BasicMVCApp.Models
{
	public class Supplier : Entity
	{
		public enum SupplierType
		{
			PhysicalPerson = 1,
			LegalPerson = 2
		}
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string Name { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 11)]
		public string Document { get; set; }
		public SupplierType Type { get; set; }
		public Address Address { get; set; }
		[Display(Name = "Ativo?")]
		public bool Active { get; set; }

		public IEnumerable<Product> Produtos { get; set; }
	}
}
