
namespace Mikaija.Dom {
	/// <summary>
	/// Leve 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-1312295772
	/// </summary>
	public interface IText : ICharacterData {
		IText SplitText(ulong offset);
	}
}
