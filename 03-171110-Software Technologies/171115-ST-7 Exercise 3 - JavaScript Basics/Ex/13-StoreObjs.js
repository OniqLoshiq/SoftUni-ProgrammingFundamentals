function solve(arr) {
    let allObjs = [];

    for (let el of arr) {
        let data = el.split(' -> ');

        let name = data[0];
        let age = +data[1];
        let grade = data[2];

        let obj = {Name: name, Age: age, Grade: grade};

        allObjs.push(obj);
    }

    for (let student of allObjs){
        console.log(`Name: ${student.Name}`);
        console.log(`Age: ${student.Age}`);
        console.log(`Grade: ${student.Grade}`);
    }
}

//solve(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']);