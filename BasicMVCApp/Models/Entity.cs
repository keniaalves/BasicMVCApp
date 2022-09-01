namespace BasicMVCApp.Models
{
	public abstract class Entity
	{
		//Não precisa ser público pois somente as classes filhas vão poder acessar
		protected Entity()
		{
			Id = Guid.NewGuid();
		}

		public Guid Id { get; set; }
	}
}
