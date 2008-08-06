
namespace Mikaija.Dom {
	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-1780488922
	/// </summary>
	public interface INamedNodeMap {
		INode GetNamedItem(string name);
		INode SetNamedItem(INode arg);
		INode RemoveNamedItem(string name);
		INode Item(ulong index);

		ulong Length { get; }
	}
}
