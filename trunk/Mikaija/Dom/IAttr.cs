
namespace Mikaija.Dom {
	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-637646024
	/// </summary>
	public interface IAttr : INode {
		string Name { get; }
		bool Specified { get; }

		string Value { get; set; }
	}
}
