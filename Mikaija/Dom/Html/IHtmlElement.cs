
namespace Mikaija.Dom.Html {
	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-html.html#ID-58190037
	/// </summary>
	public interface IHtmlElement : IElement {
		string Id { get; set; }
		string Title { get; set; }
		string Lang { get; set; }
		string Dir { get; set; }
		string ClassName { get; set; }
	}
}
