using System;
using System.Collections.Generic;
using System.Linq;

namespace Mikaija.Dom {
	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#i-Document
	/// </summary>
	public interface IDocument : INode {
		IDocumentType DocType { get; }
		IDomImplementation Implementation { get; }
		IElement DocumentElement { get; }

		IElement CreateElement(string tagName);
		IDocumentFragment CreateDocumentFragment();
		IText CreateTextNode(string data);
		IComment CreateComment(string data);
		ICDATASection CreateCDATASection(string data);
		IProcessingInstruction CreateProcessingInstruction(string target, string data);
		IAttr CreateAttribute(string name);
		IEntityReference CreateEntityReference(string name);
		INodeList GetElementsByTagName(string tagName);
	}
}
