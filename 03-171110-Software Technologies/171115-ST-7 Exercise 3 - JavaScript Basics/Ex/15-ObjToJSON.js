function solve(arr) {
    let obj = {};

    for (let el of arr) {
        let elData = el.split(' -> ');

        let value = isNaN(elData[1]) ? elData[1] : +elData[1];

        obj[elData[0]] = value;
    }

    let str = JSON.stringify(obj);

    console.log(str);
}

//solve(['name -> Angel', 'surname -> Georgiev', 'age -> 20', 'grade -> 6.00', 'date -> 23/05/1995', 'town -> Sofia']);