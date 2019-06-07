function getSevenSegments(num) {
    /*
             * SEVEN SEGMENTS
             * 
             * You get a single digit integer numer and you need to
             * show the seven segment display representation of it.
             * 
             * Ex.:
             * 1

                   |
                   |
                   |
                   |

               2
                 __ 
                   |
                 __|
                | 
                |__ 

               3
                __ 
                  |
                __|
                  | 
                __|

               4
 
                |  |
                |__|
                   |
                   |

            */
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
