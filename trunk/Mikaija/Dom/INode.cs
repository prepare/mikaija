
namespace Mikaija.Dom {
	public enum NodeType : ushort {
		ELEMENT_NODE                   = 1,
		ATTRIBUTE_NODE                 = 2,
		TEXT_NODE                      = 3,
		CDATA_SECTION_NODE             = 4,
		ENTITY_REFERENCE_NODE          = 5,
		ENTITY_NODE                    = 6,
		PROCESSING_INSTRUCTION_NODE    = 7,
		COMMENT_NODE                   = 8,
		DOCUMENT_NODE                  = 9,
		DOCUMENT_TYPE_NODE             = 10,
		DOCUMENT_FRAGMENT_NODE         = 11,
		NOTATION_NODE                  = 12,
	}

	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-1950641247
	/// </summary>
	public interface INode {
		string NodeName { get; }
		string NodeValue { get; set; }

		NodeType NodeType { get; }
		INode ParentNode { get; }
		INodeList ChildNodes { get; }
		INode FirstChild { get; }
		INode LastChild { get; }
		INode PreviousSibling { get; }
		INode NextSibling { get; }
		INamedNodeMap Attributes { get; }
		IDocument OwnerDocument { get; }

		INode InsertBefore(INode newChild, INode refChild);
		INode ReplaceChild(INode newChild, INode oldChild);
		INode RemoveChild(INode oldChild);
		INode AppendChild(INode newChild);

		bool HasChildNodes();
		INode CloneNode(bool deep);
	}
}
