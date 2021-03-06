﻿
namespace Mikaija.Dom {
	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-5431D1B9
	/// </summary>
	public interface INotation : INode {
		string PublicId { get; }
		string SystemId { get; }
	}
}
