//alert("Welcome to javascript");

let countSweet = 0;
let countSalty = 0;
let countSweetNSalty = 0;

function myMainfunction() {
    let i = 0;
    let start = prompt("Enter a starting number");
    //let start = 1;
    let end = prompt("Enter the ending number");
    //let end = 1000;
    let lineString = "";
    for (i = start; i <= end; i++) {
        // number divisible by 3 and 5 will
        // print 'Sweet' in place of the number
        lineString += MySweetNSalty(i) + ", ";
        if (i % 10 == 0) {
            console.log(lineString);
            lineString = "";
        }

    }

    console.log("\n\n\n******* Total Counts *********");
    console.log("Sweet = " + countSweet)
    console.log("Salty = " + countSalty)
    console.log("SweetNSalty = " + countSweetNSalty)

}

function MySweetNSalty(i) {
    if ((i % 5 == 0) && (i % 3 == 0)) {

        countSweetNSalty++;
        return "SweetNSalty";
    }
    if (i % 3 == 0) {
        //  Console.Write("Sweet\t");
        countSweet++;
        return "Sweet";
    }

    // number divisible by 5 print 'Salty'
    // in place of the number
    if ((i % 5) == 0) {
        //Console.Write("Salty\t");
        countSalty++;
        return "Salty";
    }

    // number divisible by 3 and 5, print 'SweetNSalty'  
    // in place of the number


    else // print the number            
        return i.toString();
    // after printing 10 numbers goto next line


}

myMainfunction();
