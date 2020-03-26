function findSymmetricNumbers(arr) {
    let endingNumber = Number(arr[0]);
    let resultNumbers = "";

    for (let i = 1; i <= endingNumber; i++) {
        let currentNumber = i.toString();

        if(isPalindrome(currentNumber)) {
            resultNumbers += i + " ";
        }
    }
    console.log(resultNumbers);

    function isPalindrome(currNum) {
        for (let i = 0; i < currNum.length / 2; i++) {
            if(currNum[i] !== currNum[currNum.length - i - 1]) {
                return false;
            }
        }

        return true;
    }
}

findSymmetricNumbers(['1130']);

function extractLargestThreeNumbers(arr) {
    arr.sort((a, b) => b - a);

    let count = Math.min(3, arr.length);

    for (let i = 0; i < count; i++) {
        console.log(arr[i]);
    }
}