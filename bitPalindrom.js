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
        throw new TypeError();
    }
    
    console.log(IsBitPalindrom(3), true);
    
    console.log(IsBitPalindrom(4), false);
    
    console.log(IsBitPalindrom(0), true);
    