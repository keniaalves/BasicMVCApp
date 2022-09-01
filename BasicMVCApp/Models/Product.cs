using System.ComponentModel.DataAnnotations;

namespace BasicMVCApp.Models
{
	public class Product : Entity
	{
		public Guid SupplierId { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string Name { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string Description { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public string Image { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public decimal Value { get; set; }
		public DateTime RegistrationDate { get; set; }
		[Display(Name = "Ativo?")]
		public bool Active { get; set; }

		public Supplier Supplier { get; set; }
	}
}
