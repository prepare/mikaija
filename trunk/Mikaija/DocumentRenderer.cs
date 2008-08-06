using Mikaija.Dom;
using Mikaija.Rendering;

namespace Mikaija {
	public class DocumentRenderer {
		private IRenderer _renderer;

		public DocumentRenderer(IRenderer renderer) {
			_renderer = renderer;
		}

		public void RenderDocument(IDocument document) {
		}
	}
}
