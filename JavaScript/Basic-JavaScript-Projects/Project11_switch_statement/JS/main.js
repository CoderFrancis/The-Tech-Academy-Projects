// Switch_Statement_Code //

function Exercise_Function()    {
    var Exercise_Output;
    var Exercises = document.getElementById("Exercise_Input").value;
    var Exercise_String = " is a great!";
    switch(Exercises)  {
        case "Bench Press":
            Exercise_Output = "Bench Press" + Exercise_String;
        break;
        case "Sqauts":
            Exercise_Output = "Sqauts" + Exercise_String;
        break;
        case "Deadlifts":
            Exercise_Output = "Deadlifts" + Exercise_String;
        break;
        case "Dumbbell Curls":
            Exercise_Output = "Dumbbell Curls" + Exercise_String;
        break;
        case "Barbell Curls":
            Exercise_Output = "Barbell Curls" + Exercise_String;
        break;
        case "Barbell Rows":
            Exercise_Output = "Barbell Rows" + Exercise_String;
        break;
        default:
        Exercise_Output = "Please enter a exercise exactly as written on the above list."
    }
    document.getElementById("Output").innerHTML = Exercise_Output;
}

// GetElementByClassName_Code_Function //

function Hello_World_Function() {
    var A = document.getElementsByClassName("Click");
    A[0].innerHTML = "The text has changed!";
}

// Canvas_Graphic //

var c = document.getElementById("ID_Name");
var ctx = c.getContext("2d");
ctx.moveTo(0, 0);
ctx.lineTo(200, 100);
ctx.stroke();

// Gradient_Code //

var c = document.getElementById("ID_Name");
var ctx = c.getContext("2d");
var grd = ctx.createLinearGradient(100, 10, 170, 100);
grd.addColorStop(0, "black");
grd.addColorStop(1, "white");
ctx.fillStyle = grd;
ctx.fillRect(20, 20, 1500, 1000);

// Form_Validation_Code //

function validateForm() {
    let x = document.forms["myForm"]["fname"].value;
    if (x == "")    {
        alert("Name must be filled out");
        return false;
    }
}

// Data_Attributes_Code //

function displayType(characters)    {
    var characterType = characters.getAttribute("data-character-type");
    alert(characterType + " is in the " + characters.innerHTML + " universe!");
}