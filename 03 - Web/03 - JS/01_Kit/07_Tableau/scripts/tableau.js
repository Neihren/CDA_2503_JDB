const people = ['Mike Dev', 'Jonh Makenzie', 'Léa Grande'];
const mainSection = document.getElementById("mainSection");
const listPerson = document.getElementById("listPerson");
const tableMain = document.getElementById("tableMain");
const tableBody = document.getElementById("tableBody");


// const node = document.createTextNode("");
// const para = document.createElement("p");
// const node = document.createTextNode("");
// para.appendChild(node);
// mainSection.appendChild(para);
personList()


function personList(){
    people.forEach(person => {
        const li = document.createElement("li");
        li.appendChild(document.createTextNode(person));
        listPerson.appendChild(li);
    });
}

function personTab(){
    people.forEach(person => {
        
    })
}