using System;
using System.Drawing;

namespace Mikaija.Rendering.Gdi {
	public class GdiRenderer : IRenderer, IDisposable {
		private Graphics _graphics;
		private Font _font;

		public GdiRenderer(int width, int height) {
			Image = new Bitmap(width, height);
			
			_graphics = Graphics.FromImage(Image);
			_graphics.FillRectangle(Brushes.White, 0, 0, width, height);

			_font = new Font("Arial", 16);
		}

		public Image Image { get; private set; }

		public void RenderText(Point point, string text) {
			_graphics.DrawString(text, _font, Brushes.Black, point.ToPointF());
		}

		public void Dispose() {
			_graphics.Dispose();
			Image.Dispose();
			_font.Dispose();
		}
	}
}
