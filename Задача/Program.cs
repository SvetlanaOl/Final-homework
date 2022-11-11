string[] decr(string[]sA)
{
int L = 0;
foreach(string s in sA)
if (s.Length<=3) L++;
string[] NewArray = new string[L];
int i = 0;
foreach(string s in sA)
if(s.Length<=3)
{
    NewArray[i] = s;
    i++;
}
return NewArray;
}
string[] sArray1 ={"Hello", "2","world", ":-)"};

string[] a = decr(sArray1);
foreach (string s in a)
Console.WriteLine(s);
