function pigLatin(word) {
    if (!word) return '';
	word = word.toLowerCase();
	var vowels = [ 'a', 'e', 'u', 'o', 'i' ];
	if (vowels.indexOf(word[0]) > -1)
		return word[0].toString().toUpperCase() + word.substr(1) + "ay";
	else
	{
		return pigLatin(word.substr(1) + word[0].toString());
	}
}

console.log("" == pigLatin(""));

console.log("Ellohay" == pigLatin("Hello"));

console.log("Odingdojocay" == pigLatin("Codingdojo"));

let a1000 = "";
for (let i = 0; i < 1000; i++)
    a1000 += "a";

console.log(`Ello${a1000}hay` == pigLatin(`Hello${a1000}`))