
namespace Mikaija.Dom {
	/// <summary>
	/// Level 1 DOM interface. Defined at http://www.w3.org/TR/2000/WD-DOM-Level-1-20000929/level-one-core.html#ID-FF21A306
	/// </summary>
	public interface ICharacterData : INode {
		string Data { get; set; }
		ulong Length { get; }

		string SubstringData(ulong offset, ulong count);
		void AppendData(string arg);
		void InsertData(ulong offset, string arg);
		void DeleteData(ulong offset, ulong count);
		void ReplaceData(ulong offset, ulong count, string arg);
	}
}
