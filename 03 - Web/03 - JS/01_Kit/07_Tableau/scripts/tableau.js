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
personTab()

const

function personList(){
    people.forEach(person => {
        const li = document.createElement("li");
        li.appendChild(document.createTextNode(person));
        listPerson.appendChild(li);
    });
}

function personTab(){
    people.forEach(person => {
        personTab = person.split(" ");
        const row = document.createElement("tr");
        const name = document.createElement("td");
        const firstname = document.createElement("td");
        const email = document.createElement("td");
        const deleteLign = document.createElement("td");
        name.appendChild(document.createTextNode(personTab[1]));
        firstname.appendChild(document.createTextNode(personTab[0]))
        email.appendChild(document.createTextNode(`${personTab[0].toLowerCase()}.${personTab[1].toLowerCase()}@gmail.com`))
        deleteLign.innerHTML = "<a href=''>X</a>"
        tableBody.appendChild(row);
        row.appendChild(name);
        row.appendChild(firstname);
        row.appendChild(email);
        row.appendChild(deleteLign);
    })
}

