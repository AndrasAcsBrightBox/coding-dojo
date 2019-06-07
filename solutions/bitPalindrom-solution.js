    /*
     * A number is considered  as a bit palindrom,
     * if it's binary representation can be reversed
     * to the same value.
     * 
     * Ex.: 
     *  Number = 3 --> `11` --> is a bit palindrom
     *  Number = 4 --> `100` --> not a bit palindrom
     *  
     *  Complete the IsBitPalindrom method and fix the unit tests :) !
     */

function IsBitPalindrom(number)
{
    let binaryRepresentation = number.toString(2);
	let p1 = binaryRepresentation.length - 1;
	for (let p0 = 0; p0 < binaryRepresentation.length / 2; p0++)
	{
		if(binaryRepresentation[p0] != binaryRepresentation[p1]) return false;
		p1--;
	}
	return true;
}

console.log(IsBitPalindrom(3), true);

console.log(IsBitPalindrom(4), false);

console.log(IsBitPalindrom(0), true);
