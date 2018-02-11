function solve(arr) {
    let obj = {};

    for (let el of arr) {
        let info = el.split(' ');
        let key = info[0];

        if (info.length > 1) {
            let value = info[1];

            obj[key] = value;
        } else {
            if (obj.hasOwnProperty(key)) {
                console.log(obj[key]);
            } else {
                console.log('None');
            }
        }
    }
}

//solve(['key value', 'key eulav', 'test tset', 'key']);