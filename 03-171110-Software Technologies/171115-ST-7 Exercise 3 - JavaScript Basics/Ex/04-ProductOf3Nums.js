function solve(arr) {
    let allNums = arr.map(Number);
    let counter = 0;
    for (let i = 0; i < allNums.length; i++){
        if(allNums[i] === 0){
            counter = 0;
            break;
        } else if(allNums[i] < 0){
            counter++;
        }
    }
    if(counter % 2 == 0){
        console.log('Positive');
    }else {
        console.log('Negative');
    }
}
//solve(['144', '0', '-1'])