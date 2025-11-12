namespace FurnitureShop
{
	internal static class App
	{
		public static string captcha = String.Empty;

		public static Bitmap GenerateCaptcha(int Width, int Height)
		{
			Random rnd = new Random();

			int Xpos = rnd.Next(0, Width - 100);
			int Ypos = rnd.Next(15, Height - 50);

			Bitmap result = new Bitmap(Width, Height);

			Brush[] colors = { Brushes.Black,
					 Brushes.Red,
					 Brushes.RoyalBlue,
					 Brushes.Green };

			Graphics g = Graphics.FromImage((Image)result);

			captcha = String.Empty;
			string ALF = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
			for (int i = 0; i < 5; ++i)
				captcha += ALF[rnd.Next(ALF.Length)];

			g.DrawString(captcha,
						 new Font("Arial", 15),
						 colors[rnd.Next(colors.Length)],
						 new PointF(Xpos, Ypos));

			g.DrawLine(Pens.Black,
					   new Point(0, 0),
					   new Point(Width - 1, Height - 1));
			g.DrawLine(Pens.Black,
					   new Point(0, Height - 1),
					   new Point(Width - 1, 0));

			for (int i = 0; i < Width; ++i)
				for (int j = 0; j < Height; ++j)
					if (rnd.Next() % 5 == 0)
						result.SetPixel(i, j, Color.White);

			return result;
		}

		public static void Error(string message)
		{
			MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void Info(string message)
		{
			MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
