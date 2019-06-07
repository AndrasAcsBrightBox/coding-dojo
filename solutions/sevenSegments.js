
function getSevenSegments(num) {
  
}

function  getStringRepresentation
    (a = false, b = false, c = false, d = false, e = false, f = false, g = false)
{
    let s = "";
    s += a 
        ? firstLineVLine
        : singleSpace;
    s += `\n`;
    s += f
        ? hLine
        : singleSpace;
    s += doubleSpace;
    s += b
        ? hLine
        : singleSpace;
        s += `\n`;
        s += f
        ? hLine
        : singleSpace;
    s += g
        ? vLine
        : doubleSpace;
    s += b
        ? hLine
        : singleSpace;
        s += `\n`;
        s += e
        ? hLine
        : singleSpace;
    s += doubleSpace;
    s += c
        ? hLine
        : singleSpace;
        s += `\n`;
        s += e
        ? hLine
        : singleSpace;
    s += d
        ? vLine
        : doubleSpace;
    s += c
        ? hLine
        : singleSpace;
    return s;
}

// 5
var expectedResult = ` __ 
|   
|__ 
   |
 __|`;
var result = getSevenSegments(5);
console.log(expectedResult == result);

// 8
expectedResult = ` __ 
|  |
|__|
|  |
|__|`;
result = getSevenSegments(8);
console.log(expectedResult == result);
