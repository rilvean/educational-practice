using FurnitureShop;
using FurnitureShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;


namespace FurnitureShop.Tests
{
	public class AppTests
	{
		private DbContextOptions<Context> _dbContextOptions;

		public AppTests()
		{
			_dbContextOptions = new DbContextOptionsBuilder<Context>()
				.UseInMemoryDatabase(databaseName: $"FurnitureShopTestDb_{System.Guid.NewGuid()}")
				.Options;
		}

		[Fact]
		public void GenerateCaptcha_ShouldReturnBitmap()
		{
			// Act
			Bitmap bmp = App.GenerateCaptcha(300, 200);

			// Assert
			Assert.NotNull(bmp);
		}

		[Fact]
		public void GenerateCaptcha_ShouldSetCaptcha()
		{
			// Act
			Bitmap bmp = App.GenerateCaptcha(300, 200);

			// Assert
			Assert.NotNull(App.captcha);
			Assert.Equal(4, App.captcha.Length);
		}

		[Fact]
		public void LogUser_ShouldAddEntranceLog()
		{
			// Arrange
			using var context = new Context(_dbContextOptions);
			var user = new User
			{
				Id = 1,
				FullName = "Test User",
				Role = "User",
				Login = "test",
				Password = "pass"
			};
			context.Users.Add(user);
			context.SaveChanges();

			// Act
			App.LogUser(user, context);

			// Assert
			var log = context.EntranceLogs.SingleOrDefault();
			Assert.NotNull(log);
			Assert.Equal(user.Id, log.UserId);
			Assert.Equal(user.FullName, log.FullName);
			Assert.Equal(user.Role, log.Role);
		}
	}
}