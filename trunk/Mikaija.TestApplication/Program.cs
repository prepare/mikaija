using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mikaija.Rendering.Gdi;
using Mikaija.Rendering;

namespace Mikaija.TestApplication {
	class Program {
		static void Main(string[] args) {
			var form = new Form {
				Text = "Excalibur",
				ClientSize = new System.Drawing.Size(800, 600)
			};

			var surface = new GdiRenderer(800, 600);
			surface.RenderText(new Point { X = 10, Y = 10 }, "w00t!");

			form.BackgroundImage = surface.Image;
			Application.Run(form);
		}
	}
}
