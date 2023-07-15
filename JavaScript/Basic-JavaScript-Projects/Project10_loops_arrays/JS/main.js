function count_To_Ten() {
    var Digit = "";
    var X = 1;
    while (X < 11)  { 
        Digit += "<br>" + X;
        X++;
    }
    document.getElementById("counting_To_Ten").innerHTML = Digit;
}

// String_Length //

let text = "Hello World!";
let length = text.length;

// For_Loops_in_JavaScript //

var Instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin", "Trumpet", "Flute"];
var Content = "";
var Y;
function for_Loop() {
    for (Y = 0; Y < Instruments.length; Y++)    {
        Content += Instruments[Y] + "<br>";
    }
    document.getElementById("List_of_Instruments").innerHTML = Content;
}

// Array_Function //

function exercises() {
    var Human_Picture = [];
    Human_Picture[0] = "bench_press";
    Human_Picture[1] = "barbell_sqauts";
    Human_Picture[2] = "barbell_row";
    Human_Picture[3] = "barbell_curl";
    document.getElementById("Human").innerHTML = "In this picture, the human is doing a " +
        Human_Picture[0]  + ".";
}

// Constant_Function //

function constant_function()    {
    const Musical_Instrument = {type:"guitar", brand:"Fender", color:"black"};
    Musical_Instrument.color = "blue";
    Musical_Instrument.price = "$900";
    document.getElementById("Constant").innerHTML = "The cost of the " +
        Musical_Instrument.type + " was " + Musical_Instrument.price;
}

// Let_Keyword //

var X = 82;
document.write(X);
{
    let X = 33;
    document.write("<br>" + X);
}
document.write("<br>" + X);

var X = 82;
document.write(X);
{
    var X = 33;
    document.write("<br>" + X);
}
document.write("<br>" + X);

// Object //

let car = {
    make: "Dodge ",
    model: "Viper ",
    year: "2021 ",
    color: "red ",
    description: function() {
        return "This car is a " + this.year + this.color + this.make + this.model;
    }
};
document.getElementById("Car_Object").innerHTML = car.description();

// Break_Statement //

for (let i = 0; i < 10; i++)    {
    if (i === 3)  { break; }
    text += "The number is " + i + "<br>"
}

// Continue_Statement //

for (let i = 0; i < 10; i++)    {
    if (i === 3)  { continue; }
    text += "The number is " + i + "<br>"
}