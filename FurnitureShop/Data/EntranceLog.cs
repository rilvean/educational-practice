namespace FurnitureShop.Data
{
	public partial class EntranceLog
	{
		public int Id { get; set; }

		public int UserId { get; set; }
		public string FullName { get; set; } = null!;
		public string Role { get; set; } = null!;
		public DateTime LogInTime { get; set; }

		public virtual User User { get; set; } = null!;
	}
}
