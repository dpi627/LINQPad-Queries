<Query Kind="Statements" />

// 模擬 SQL 搜尋條件
List<string> aryParams = new List<string> {
	"3",
	"",		// empty string
	" ",	// white space
	"2",
	1 == 1 ? "1" : "0"
};
// 模擬其他額外條件
aryParams.Add(1 == 1 ? null : "");
// 濾除無效陣列元素，並在各元素之間加入 " and " 組成單一字串
string qryParam = string.Join(" and ", aryParams.Where(p => !string.IsNullOrWhiteSpace(p)));
qryParam = string.IsNullOrWhiteSpace(qryParam) ? "" : $" and ({qryParam})";

aryParams.Dump();
qryParam.Dump();