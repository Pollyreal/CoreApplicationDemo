class Student {
    fullName: string;
    constructor(public firstName, public middleInitial, public lastName) {
        this.fullName = `${firstName} ${middleInitial} ${lastName}`;
    }
}
interface Person {
    firstName: string;
    lastName: string;
}
function greeter(person: Person) {
    let a: number = 6;
    let b: boolean = true;
    let c: Array<number> = [1, 2, 3];
    //Tuple
    let x: [string, number];
    x = ['hello', 10];
    for (let i of c) {
        console.log(`haha 我就是这么${a},这是${b}的`);
    }
    return `Hello, ${person.firstName} ${person.lastName}`;
}
function test(): void {
    enum Color { Red = 1, Green, Blue };
    let a: Color = Color.Green;
    let notSure: any = 4;
}
var user = new Student('Polly', 'Null', 'Ng');
document.body.innerHTML = greeter(user); 