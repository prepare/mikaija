
namespace Mikaija.Dom {
	/// <summary>
	/// Leve 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-745549614
	/// </summary>
	public interface IElement {
		string TagName { get; }

		string GetAttribute(string name);
		void SetAttribute(string name, string value);
		void RemoveAttribute(string name);

		IAttr GetAttributeNode(string name);
		IAttr SetAttributeNode(IAttr newAttr);
		IAttr RemoveAttributeNode(IAttr oldAttr);

		INodeList GetElementsByTagName(string name);
		void Normalize();
	}
}
