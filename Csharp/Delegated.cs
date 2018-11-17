/*
call function in dictionary
example:
	int commandFunctions(List<string> elements){...}
	int miscFunctions(){...}

*/

delegate int DelegateCommandFunctions(List<string> elements);
delegate int DelegateMiscFunctions();

Dictionary<string, Delegate> commandFunctions = new Dictionary<string, Delegate>();
commandFunctions.Add("f1", new DelegateCommandFunctions(f1));
commandFunctions.Add("f2", new DelegateCommandFunctions(f2));
//...
Dictionary<string, Delegate> miscFunctions = new Dictionary<string, Delegate>();
miscFunctions.Add("f3", new DelegateMiscFunctions(f3));
miscFunctions.Add("f4", new DelegateMiscFunctions(f4));
//...

//call
List<string> elements = new List<string>();
//elements.Add ...
string result1 = (string)commandFunctions["f1"].DynamicInvoke(elements);
string result3 = (string)miscFunctions["f3"].DynamicInvoke();
