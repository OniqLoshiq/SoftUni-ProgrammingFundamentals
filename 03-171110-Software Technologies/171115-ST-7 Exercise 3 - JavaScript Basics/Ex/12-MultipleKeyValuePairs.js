function solve(arr) {
    let obj = {};

    for (let el of arr) {
        let info = el.split(' ');
        let key = info[0];

        if (info.length > 1) {
            let value = info[1];
            if (!obj.hasOwnProperty(key)) {
                obj[key] = new Array();
            }
            obj[key].push(value);
        } else {
            if(obj.hasOwnProperty(key)){
                for (let el of obj[key]){
                    console.log(el);
                }
            } else {
                console.log('None');
            }
        }
    }
}

//solve(['key value', 'key eulav', 'test tset', 'key']);