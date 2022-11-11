string[] decr(string[]sA)
{
int L = 0;
foreach(string s in sA)
if (s.Length<=3) L++;
string[] NewArray = new string[sA.Length];
int i = 0;
foreach(string s in sA)
if(s.Length<=3)
{
    NewArray[i] = s;
    i++;
}
return NewArray;
}