let people = ['Mike Dev', 'Jonh Makenzie', 'Léa Grande'];
const listPerson = document.getElementById("listPerson");
const tableMain = document.getElementById("tableMain");
const tableBody = document.getElementById("tableBody");

personList()
personTab()

function deleteSomeone(event) {
    const btn = event.target;
    const index = btn.dataset.position;
    console.log(btn);
    people.splice(index, 1);
    personList();
    personTab();
}


function personList(){
    listPerson.innerHTML = "";
    people.forEach(person => {
        const li = document.createElement("li");
        li.appendChild(document.createTextNode(person));
        listPerson.appendChild(li);
    });
}

function personTab(){
    let i = 0;
    tableBody.innerHTML = "";
    people.forEach(person => {
        const listPeople = person.split(" ");
        const row = document.createElement("tr");
        const name = document.createElement("td");
        const firstname = document.createElement("td");
        const email = document.createElement("td");
        const deleteLign = document.createElement("td");
        const btnDelete = document.createElement("a")
        name.appendChild(document.createTextNode(listPeople[1]));
        firstname.appendChild(document.createTextNode(listPeople[0]))
        email.appendChild(document.createTextNode(`${listPeople[0].toLowerCase()}.${listPeople[1].toLowerCase()}@gmail.com`))
        btnDelete.textContent = "X";
        btnDelete.href = "#";
        btnDelete.dataset.position = i;
        i++;
        btnDelete.addEventListener("click", deleteSomeone);
        tableBody.appendChild(row);
        row.appendChild(name);
        row.appendChild(firstname);
        row.appendChild(email);
        row.appendChild(deleteLign);
        deleteLign.appendChild(btnDelete);
    })
}