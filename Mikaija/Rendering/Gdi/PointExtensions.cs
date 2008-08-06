using System.Drawing;

namespace Mikaija.Rendering.Gdi {
	public static class PointExtensions {
		public static PointF ToPointF(this Point point) {
			return new PointF(point.X, point.Y);
		}
	}
}
