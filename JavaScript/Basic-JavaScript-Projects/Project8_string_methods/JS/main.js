// Concatenate - connection to full sentence - code //

function full_sentence()    {
    var part_1 = "I have ";
    var part_2 = "made this ";
    var part_3 = "into a complete ";
    var part_4 = "sentence.";
    var whole_sentence = part_1.concat(part_2, part_3, part_4);
    document.getElementById("Concatenate").innerHTML = whole_sentence;
}

// slice_method code //

function slice_method() {
    var Sentence = "All work and no play makes Johnny a dull boy.";
    var Section = Sentence.slice(27,33);
    document.getElementById("Slice").innerHTML = Section;
}

// toUpperCase method //

let text = "Hello World!";
let result = text.toUpperCase();

document.getElementById("demo_1").innerHTML = result;

//  Search()method //

let text2 = "Mr. Francis has a orange house";
let position = text2.search("Francis");

document.getElementById("demo_2").innerHTML = position;

//  string_method //

function string_Method()    {
    var X = 182;
    document.getElementById("Numbers_to_string").innerHTML = X.toString();
}

//  precision_method //

function precision_Method() {
    var X = 12938.3012987376112;
    document.getElementById("Precision").innerHTML = X.toPrecision(10);
}

//  toFixed_method //

let num = 5.56789;
let n = num.toFixed();

document.getElementById("toFixed_method").innerHTML = position;

// valueOf method//

let text3 = "Hello World!";
let result2 = text.valueOf();

document.getElementById("valueOf_method").innerHTML = position;

