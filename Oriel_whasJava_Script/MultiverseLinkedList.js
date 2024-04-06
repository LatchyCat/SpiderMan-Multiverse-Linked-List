

class Node {
    constructor(spiderman) {
        this.spiderman = spiderman;
        this.next = null;
    };
};


class MultiverseNodeCreator {
    constructor() {
    this.head = null;
    this.tail = null;
    this.length = 0;
    };

    push(spiderman) {
        let newSpiderMan = new Node(spiderman)
        if (!this.head || !this.tail) {
            this.head = newSpiderMan;
            this.tail = this.head;
        } else {
            this.tail.next = newSpiderMan;
            this.tail = newSpiderMan
        };
        this.length++;
    };

    pop() {
        if (!this.head) {
            return null;
        };

        let currentSpiderman = this.head;
        let previousSpiderman = null;

        while (currentSpiderman.next) {
            previousSpiderman = currentSpiderman;
            currentSpiderman = currentSpiderman.next;
        };

        this.tail = previousSpiderman;

        if (!previousSpiderman) {
            this.head = null;
        } else {
            previousSpiderman.next = null;
        };

        this.length--;
        return currentNode.spiderman;
    };


    shift() {
        if (!this.head) {
            return null;
        };

        let shiftedSpiderman = this.head;
        this.head = this.head.next;
        this.length--;

        if (!this.head) {
            this.tail = null;
        };

        return shiftedSpiderman.spiderman;
    };


    unshift(spiderman) {
        let newSpiderMan = new Node(spiderman);
        if (!this.head) {
            this.head = newSpiderMan;
            this.tail = this.head;
        } else {
            newSpiderMan.next = this.head;
            this.head = newSpiderMan;
        }
        this.length++;
    };
};
