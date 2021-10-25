using GridShared;
using System.Collections.Generic;

namespace GridBlazor
{
	public interface IExcelWriter
	{
		byte[] GenerateExcel(ExcelData data);
		byte[] GenerateExcel<T>(IGridColumnCollection<T> columns, IEnumerable<T> items);
	}
}