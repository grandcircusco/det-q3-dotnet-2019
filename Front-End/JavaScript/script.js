// var name = "Adam";
// //no diff. between a float and an int in JS. Everything is just a number

// name = 20;
// name = 0.3
// name = true;

// //Previously, JS only had var.
// //Now JS has "let" or "const"

// let age = 32; //another way to declare a variable
// //diff. b/w let & var. --- scope
// //let created in a code block will only be accessible w/in that code block
// //let can otherwise be treated as a regular variable

// const dog = "Syntax";
// //const is the same as C# const. Once set, it cannot be changed.

// //In JavaScript, let & const are the primary two variables
// for (var i = 0; i <5; i++){ //var here will keep the variable
//                             //i going beyond the scope of the for-loop. BAD
//     console.log(i);
// }

// class Student{
// constructor(name, age){
// this.name = name; //because we have these properties in the constructor,
// this.age = age; //we need to set it using this.
// this.knowledge = 0;
// }
// party(){
//     this.knowledge++;
// }
// }

// let zel = new Student("Zel", 29);
// zel.party();
// console.log(zel);

// function hello(){
//     console.log("hello");
// }

// hello();

// //arrow function - creating a variable and setting it to the result of the area function
// const getArea = (length, width) => {
// console.log(length * width)
// }

// getArea = (length, width) => (length*width);
// //instead of using the return keyword.
// getArea(50, 10);
// function getArea(length, width){
//     console.log(length*width);
// }

// //one-parameter arrow funciton - no ()
// const greetPerson = name => "hello " +name;
// //not parameter arrow funciton
// const sayHi = () => console.log("hello");

//every tab on any browser has a built-in window object
//window object contains all of the window's history & information
//console.log(window); ---> shows everything that's tracked on the tab's window object

//how facebook/google knows all about us
//after the window object is the document object which is strictly related to the HTML document
//console.log(document) ---> shows whatever website's HTML.
//javascript is used to interact with this object - why JS is used in front-end

//string can be either a tag, a class or an id
//and they will be selected the same way you would call a
//tag, class, or id in CSS ---> #name (id= name),
//.contact-form (class = contact-form)
//form (<form> </form>)
let form = document.querySelector(".contact-form");
//^ this says, let's go through the document and find
//all selectors of this particular class.
console.dir(form);
//^checking out our DOM in the console
//lets us see everything that the form contains
//including children, properties (inclduing all events you
//can assign to the element), location
//a way to navigate to every child, sibling, and parent
//at any time
//includes every declaration available to this element
//in CSS

//declaring a lsit called contactList, which is empty
let contactList = [];

//going to target the form object and store it for future use
form.addEventListener("submit", function(event) {
  event.preventDefault();
  console.log("The form has been submitted");
  //use console.dir when trying to log out an html element
  let name = document.querySelector("#name").value;
  let phoneNumber = document.querySelector("#phone-number").value;
  contactList.push({
    //using an object literal:
    name, //do not need to set up a key/value pair
    //name:"adam", phoneNumber: "fjdlkaf"
    //because the properties already have values
    phoneNumber
  });
  //push is a method. remember the parentheses
  displayContacts();
});
//submit - the anme fo the event we are listening for.
//when that submit is heard, we want a function to run
//"call back funciton" - even that runs as soon as an event is triggered
//event - not in quotes - along with event.preventDefault
//will prevent the page from
//refreshing itself when we submit the form.

function displayContacts() { //element represents each object in the array
    let contactListDiv = document.querySelector(".contact-list");
    contactListDiv.innerHTML = ""; //clears out HTML
    //so the html only displays the elements once
    contactList.forEach(function(element, index){
        let div = document.createElement("div");
        //^this is how we create HTML elements in JS
        div.classList.add("contact-card");
        div.innerHTML = `
        <p class="contact-data">Name: ${element.name} </p>
        <p class="contact-data">Phone Number: ${element.phoneNumber} </p>
        <button index=${index}>X</button>
        `;
        //back ticks allow JS to utilize multiline strings,
        //along with expressions to be inserted into the strings
        //instead of incantination or + + + 
        //JS's version of string interpolation
        contactListDiv.append(div);
        //this is adding the newly created div into the 
        //contactListDiv
    });
}

document.querySelector(".contact-list")
.addEventListener("click", function(event){
console.log(event); //event is representing the click 
//that actually happens
if(event.target.tagName === "BUTTON"){
    console.log(event.target.attributes[0].value);
    contactList.splice(event.target.attributes[0].value, 1);
    //clicking the div will cause an event,
    //but we can specify that something else will happen
    //like when we click a button

    //event.target.attributes[0].value -- what we use 
        //to access the index of all of our objects
        //attributes[0] is because attributes in an 
        //element have their own indexes
    //attributes is a property of every html element
    displayContacts();
}
});

//add a mouse enter event
document.querySelector(".contact-list")
.addEventListener("mouseover", function(event){
if(event.target.classList.contains("contact-data")){
    event.target.classList.add("data-hover");
}
})

//add a mouse leave event

document.querySelector(".contact-list")
.addEventListener("mouseout", function(event){
if(event.target.classList.contains("contact-data")){
    event.target.classList.remove("data-hover");
}
})