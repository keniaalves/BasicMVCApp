using System.ComponentModel.DataAnnotations;

namespace BasicMVCApp.Models
{
	public class Address : Entity
	{
		public Guid SupplierId { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string Street { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string Number { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string District { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string Adjunct { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(8, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 8)]
		public string PostalCode { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string City { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
		public string State { get; set; }

		public Supplier Supplier { get; set; }
	}
}
