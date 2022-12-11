using System.Collections;

var someList = new ArrayList() {"lol", "hey", "ok", 32, 5};

var resultList = new ArrayList();
resultList = ArrayItemCount(someList);

foreach (var item in resultList)
{
	Console.WriteLine(item);
}

static ArrayList ArrayItemCount(ArrayList someList)
{
	int intCount = 0;
	int strCount = 0;
	int otherType = 0;
	var countList = new ArrayList();

	foreach (var item in someList)
	{
		if (item is int)
			intCount++;
		else if (item is string)
			strCount++;
		else
			otherType++;
	}

	countList.Add(intCount); countList.Add(strCount); countList.Add(otherType);

	return countList;
}