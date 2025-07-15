const inputDOB = document.getElementById("inputDOB")
const btnCalculate = document.getElementById("btnCalculate")
const info = document.getElementById("info")
const sign = document.getElementById("sign")

function calculateAge(){
    console.log(inputDOB)
    console.log(inputDOB.value)
}

btnCalculate.addEventListener("click", calculateAge)
