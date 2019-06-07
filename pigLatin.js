function pigLatin(word) {
     /*
	* Pig Latin
	* 
	* Pig latin is a word play for English speakers.
	* The word is cut at the first vowel and the two parts are changed,
	* plus to the en an 'ay' is added.
	* 
	* Ex.:
	* 
	*  Hello --> Ellohay
	*/

	throw new TypeError();
}

console.log("" == pigLatin(""));

console.log("Ellohay" == pigLatin("Hello"));

console.log("Odingdojocay" == pigLatin("Codingdojo"));

let a1000 = "";
for (let i = 0; i < 1000; i++)
    a1000 += "a";

console.log(`Ello${a1000}hay` == pigLatin(`Hello${a1000}`))