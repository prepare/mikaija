using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikaija.Rendering {
	public interface IRenderer {
		void RenderText(Point point, string text);
	}
}
