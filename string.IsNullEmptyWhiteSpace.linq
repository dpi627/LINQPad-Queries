<Query Kind="Statements" />

string.IsNullOrEmpty(null).Dump();
string.IsNullOrWhiteSpace(null).Dump();

string.IsNullOrEmpty("").Dump();
string.IsNullOrWhiteSpace("").Dump();

string.IsNullOrEmpty(" ").Dump();
string.IsNullOrWhiteSpace(" ").Dump();

string s=string.Empty;
string.IsNullOrEmpty(s).Dump();
string.IsNullOrWhiteSpace(s).Dump();