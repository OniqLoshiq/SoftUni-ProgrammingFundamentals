function solve(arr) {
    let arrToPrtn = [];

    for (let i = 0; i < arr.length; i++) {
        let cmd = arr[i].split(' ')[0];
        let num = +(arr[i].split(' ')[1]);

        if(cmd === 'add'){
            arrToPrtn.push(num);
        } else if (cmd === 'remove'){
            if(num < 0 || num > arrToPrtn.length - 1){
                continue;
            }
            arrToPrtn.splice(num, 1);
        }
    }

    for (let el of arrToPrtn){
        console.log(el);
    }
}

//solve(['add 3', 'add 5', 'remove 1', 'add 2']);