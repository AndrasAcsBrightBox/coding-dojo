<Query Kind="Program" />

void Main()
{
	GetBinaryStringFromInt(21).Dump();
	IsBitPalindrom(21).Dump();
	IsBitPalindrom(22).Dump();
	
	GetBinaryStringFromInt(int.MaxValue).Dump();
	
	IsFastBitPalindrom(21).Dump();
}

public bool IsFastBitPalindrom(int number) 
{
	int reversed = 0;
    int aux = number;

    while (aux > 0)
    {
        int lsb = aux & 1;
        reversed = (reversed << 1) | lsb;
        aux = aux >> 1;
    }
    return reversed == number;
}

public bool IsBitPalindrom(int number)
{
	string binaryRepresentation = GetBinaryStringFromInt(number);
	int p1 = binaryRepresentation.Length - 1;
	for (int p0 = 0; p0 < binaryRepresentation.Length / 2; p0++)
	{
		if(binaryRepresentation[p0] != binaryRepresentation[p1]) return false;
		p1--;
	}
	return true;
}

public string GetBinaryStringFromInt(int tenBasedNumber)
{
	string binaryRepresentation = "";
	while(tenBasedNumber != 0)
	{
		binaryRepresentation = (tenBasedNumber % 2).ToString() + binaryRepresentation;
		tenBasedNumber /= 2;
	}
	return binaryRepresentation;
}

// Define other methods and classes here
