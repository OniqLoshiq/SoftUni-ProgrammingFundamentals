function solve(arr) {
    let arrayToPrtn = new Array(+arr[0]);
    arrayToPrtn.fill(0);
    for (let i = 1; i < arr.length; i++){
        let index = +(arr[i].split(' ')[0]);
        let value = +(arr[i].split(' ')[2]);

        arrayToPrtn[index] = value;
    }

    for (let el of arrayToPrtn){
        console.log(el);
    }
}

//solve(['5', '0 - 3', '3 - -1', '4 - 2'])