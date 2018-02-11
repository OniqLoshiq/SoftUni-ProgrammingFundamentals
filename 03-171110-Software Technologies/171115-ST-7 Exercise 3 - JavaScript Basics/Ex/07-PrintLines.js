function solve(n) {
    for (let el of n){
        if(el === 'Stop'){
            break;
        } else {
            console.log(el);
        }
    }
}

//solve(['Line 1', 'Line 2', 'Stop'])