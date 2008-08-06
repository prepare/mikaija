
namespace Mikaija.Dom.Html {
	public interface IHtmlDocument : IDocument {
		string Title { get; set; }

		IHtmlElement Body { get; set; }

		IElement GetElementById(string elementId);
	}
}
