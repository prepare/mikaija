
namespace Mikaija.Dom {
	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-412266927
	/// </summary>
	public interface IDocumentType {
		string Name { get; }
		INamedNodeMap Entities { get; }
		INamedNodeMap Notations { get; }
	}
}
