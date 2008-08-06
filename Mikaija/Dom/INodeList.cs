
namespace Mikaija.Dom {
	public interface INodeList {
		INode Item(ulong index);
		ulong Length { get; }
	}
}
