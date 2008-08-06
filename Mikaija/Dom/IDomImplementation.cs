
namespace Mikaija.Dom {
	// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-102161490
	public interface IDomImplementation {
		bool HasFeature(string feature, string version);
	}
}
