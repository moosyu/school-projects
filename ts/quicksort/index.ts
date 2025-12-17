var sortList: number[] = generateList(10, 10);

console.log(`Unsorted list: ${sortList}`);
console.log(quickSort(sortList));

function generateList(listLength: number, maxNumber: number): number[] {
    var generatedList: number[] = [];
    for (let i = 0; i < listLength; i++) {
        generatedList.push(Math.floor(Math.random() * maxNumber));
    }
    return generatedList;
}

function quickSort(sortList: number[]): number[] {
    if (sortList.length <= 1) {
        return sortList;
    }

    const pivotIndex: number = Math.floor(sortList.length / 2);
    const pivot: number = sortList[pivotIndex];
    const tempSortedListHigh: number[] = [];
    const tempSortedListLow: number[] = [];

    for (let i = 0; i < sortList.length; i++) {
        if (i === pivotIndex) {
            continue;
        }
        if (sortList[i] < pivot) {
            tempSortedListLow.push(sortList[i]);
        } else {
            tempSortedListHigh.push(sortList[i]);
        }
    }
    // full forgot a spread was even a thing and was doing some insane concat stuff
    // is recursion like this a good idea btw?
    return [...quickSort(tempSortedListLow), pivot, ...quickSort(tempSortedListHigh)];
}