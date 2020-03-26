function multiplyANumberByTwo(arr) {
    return Number(arr[0]) * 2;
}

function multiplyTwoNumbers(arr) {
    let firstNumber = Number(arr[0]);
    let secondNumber = Number(arr[1]);

    return firstNumber * secondNumber;
}

function multiplyOrDivideNumberBySecondNumber(arr) {
    let firstNumber = Number(arr[0]);
    let secondNumber = Number(arr[1]);

    if(firstNumber <= secondNumber) {
        return firstNumber  * secondNumber;
    } else {
        return firstNumber / secondNumber;
    }
}

function productOfThreeNumbers(arr) {
    arr = arr.map(Number);
    let countOfNegatives = 0;

    for (let i = 0; i < arr.length; i++) {
        if(arr[i] < 0){
            countOfNegatives++;
        }
    }

    if(countOfNegatives % 2 === 0) {
        console.log("Positive");
    } else {
        console.log("Negative");
    }
}

function printNumbersFrom1ToN(arr) {
    for (let i = 1; i <= Number(arr[0]); i++) {
        console.log(i);
    }
}

function printNumbersFromNto1(arr) {
    for (let i = Number(arr[0]); i > 0; i--) {
        console.log(i);
    }
}

function printLines(arr) {
    for (let i = 0; i < arr.length; i++) {
        if(arr[i] === "Stop") {
            break;
        } else {
            console.log(arr[i]);
        }
    }
}

function printNumbersInReversedOrder(arr) {
    for (let i = arr.length - 1; i >= 0; i--) {
        console.log(arr[i]);
    }
}

function setValuesToIndexesInArray(arr) {
    let length = Number(arr[0]);
    let resultArray = [];

    for (let i = 1; i < arr.length; i++) {
        let currentCommand = arr[i].split(" - ");
        let index = currentCommand[0];
        let number = currentCommand[1];

        resultArray[index] = number;
    }

    for (let i = 0; i < length; i++) {
        if(resultArray[i] === null || resultArray[i] === undefined) {
            resultArray[i] = 0;
        }
        console.log(resultArray[i]);
    }
}

function addOrRemoveElements(arr) {
    let resultArray = [];

    for (let i = 0; i < arr.length; i++) {
        let currentCommand = arr[i].split(' ');

        if(currentCommand[0] === "add") {
            resultArray.push(Number(currentCommand[1]));
        } else {
            let index = Number(currentCommand[1]);
            if(index > resultArray.length - 1) {
                continue;
            } else {
                resultArray.splice(Number(index), 1);
            }
        }
    }

    for (let num of resultArray) {
        console.log(num);
    }
}

function workingWithKeyValuePairs(arr) {
    let result = {};

    for (let i = 0; i < arr.length - 1; i++) {
        let currentKeyValuePair = arr[i].split(' ');
        let key = currentKeyValuePair[0];
        let value = currentKeyValuePair[1];

        result[key] = value;
    }

    if(result[arr[arr.length - 1]] !== undefined) {
        console.log(result[arr[arr.length - 1]]);
    } else {
        console.log("None");
    }
}

function multipleValuesForAKey(arr) {
    let result = {};

    for (let i = 0; i < arr.length - 1; i++) {
        let currentKeyValuePair = arr[i].split(' ');
        let key = currentKeyValuePair[0];
        let value = currentKeyValuePair[1];

        if(result[key] === undefined) {
            result[key] = [];
            result[key].push(value);
        } else {
            result[key].push(value);
        }
    }

    if(result[arr[arr.length - 1]] !== undefined) {
        for (let value of result[arr[arr.length - 1]]) {
            console.log(value);
        }
    } else {
        console.log("None");
    }
}

function storingObjects(arr) {
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        let currentObject = {};

        let currentPerson = arr[i].split(" -> ");
        let name = currentPerson[0];
        let age = currentPerson[1];
        let grade = currentPerson[2];

        currentObject["Name"] = name;
        currentObject["Age"] = age;
        currentObject["Grade"] = grade;

        result.push(currentObject);
    }

    for (let i = 0; i < result.length; i++) {
        let currentPerson = result[i];

        console.log("Name: " + currentPerson.Name);
        console.log("Age: " + currentPerson.Age);
        console.log("Grade: " + currentPerson.Grade);
    }
}

function parseJSONObjects(arr) {
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        let currentObject = JSON.parse(arr[i]);

        result.push(currentObject);
    }

    for (let i = 0; i < result.length; i++) {
        console.log("Name: " + result[i].name);
        console.log("Age: " + result[i].age);
        console.log("Date: " + result[i].date);
    }
}

function turnJSObjectIntoJSONString(arr) {
    let resultObject = {};

    for (let i = 0; i < arr.length; i++) {
        let currentProperty = arr[i].split(" -> ");
        let property = currentProperty[0];
        let value = currentProperty[1];

        if(!isNaN(value)) {
            value = Number(value);
        }

        resultObject[property] = value;
    }

    let resultString = JSON.stringify(resultObject);
    console.log(resultString);
}
