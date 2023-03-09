/*
    Ma. Fernanda Cortés Lozano - A01026613
    Actividad en clase: Javascript
*/

/* Escribe una función que encuentre el primer carácter de un cadena de texto que no se
repite. Prueba tu función con: 'abacddbec'*/

function NoRepeat(str){

let frequency = {};

for (let i=0; i<str.lenght; i++){
    if(frequency[str[i]]){
        frequency[str[i]]++;
    } else {
        frequency[str[i]] = 1;
    }

    console.log(frequency);
    return null;
}

for (let i=0; i<str.lenght; i++){
    if(frequency[str[i]] === 1){
        return str[i];
    }
}
    
}

let result=NoRepeat("abacddbec");
console.log(result);