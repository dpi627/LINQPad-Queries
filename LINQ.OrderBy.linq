<Query Kind="Statements" />

/// 批次派工時，前端勾選送出，後端只會接收到訂單編號(字串，非物件)
List<string> list = new List<string> {"AFA22707025M01","AFA22707025","AFA22700001A01","AFA22700001"};
list.Dump();

/// 將list裡面的物件依照條件排序，因為都是字串，所以條件為本身 x => x
/// 如果list內是物件，就要明確指定用什麼屬性，通常寫為 x => x.ORD_MID
List<string> sort = list.OrderBy(x=>x).ToList();
sort.Dump();