class Shape {
    name: string;
    height: number;
    width: number;
    area: number;

    constructor(name: string, height: number, width: number) {
        this.name = name;
        this.height = height;
        this.width = width;
        this.area = 0;
    }
}

class Rectangle extends Shape {
    constructor(height: number, width: number) {
        super("Rectangle", height, width);
        this.area = height * width;
    }
}

class Circle extends Shape {
    constructor(radius: number) {
        super("Circle", radius * 2, radius * 2);
        this.area = Math.round(Math.PI * Math.pow(radius, 2));
    }
}

let objArray: Shape[] = [];
objArray.push(new Rectangle(20, 20));
objArray.push(new Circle(5));

console.table(objArray);