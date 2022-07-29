// let user = {
	// name: "John",
	// age: 30,
	// "1 2 3": true
// }; // литерал

// // console.log(user.name);
// // console.log(user.age);

// user.isAdmin = true;
// // console.log(user.isAdmin);

// //delete user.isAdmin;
// //console.log(user.isAdmin);

// // console.log(user["1 2 3"]); // new way get property

// const userr = {
	// name: "Tom"
	// };
	// userr.name = "Pete";
	// // console.log(userr.name);
	
// //let fruit = prompt("Fruit: ", "apple");
// //let bag = {
// //	[fruit] : 5
// //}
// //console.log(bag.apple);
// //console.log(bag.cherry);
// //let user1 = new Object();

// function makeUser(name, age)
// {
	// return {
		// name,
		// age
	// }
// }

// let obj = {
	// for: 1,
	// let:2,
	// return: 3
// };

// // console.log(obj.for + obj.let + obj.return);

// // is (as)

// //in 

// let ww = {test1 : true,
// test2:"str",
// test: undefined
// };
// // console.log(ww.Test === undefined) // true 
// // "key" in object

// // console.log("test1" in ww);
// // console.log("blabla" in ww);
// // console.log(ww.test22);

// // console.log("test" in ww);
// //let rrrrrr;

// //for(key in object) {}

// // for(let key in ww)
// // {
	// // console.log(key);
	// // console.log(ww[key]);
// // }

// let mess = "Hello!";
// let mess1 = mess;
// // console.log(mess);
// // console.log(mess1);
// // mess = "Hi:)";
// // console.log(mess);
// // console.log(mess1);

// let y = {name: "Ivan"};
// let admin = y;
// //console.log(y.name);
// //console.log(admin.name);

// y.name = "Vasya";

// // console.log(y.name);
// // console.log(admin.name);
// // == === 
// // console.log(admin == y);
// // console.log(admin === y);

// let u = {};
// let q = {};
// // console.log(u == q);

// let test1 = {
	// name: "John",
	// age: 30,
// }
// let clone = {};

// for(let key in test1)
// {
	// clone[key] = test1[key];
// }

// //Object.assign (dest, [src1, src2...])

// let qwe = {name:"Ivan"};
// let perm1 = {canView : true};
// let perm2 = {canEdit: false};

// let perm3 = {canEdit: 22};


// Object.assign(qwe, perm1, perm2, perm3);
// perm1.canView = false;
// for(let key in qwe)
// {
	// console.log(key,",", qwe[key]);
// }
// console.log(perm1.canView);

let user = {
	 name: "John",
	 age: 30,
	 sayBy: function()
	 {
		 console.log("sayBy: ^_^");
	 }
}
user.sayHi = function() // Function Expression
{
	console.log("Hi: ^_^");
}

user.sayHi();

function sayHello()
{
	console.log("Hello: :) ");
}
user.sayHello = sayHello;
user.sayHello();
user.sayName = function()
{
	console.log(this.name);
}
user.sayName();

let user1 = {
	firstName: "Kris",
	sayHi()
	{
		let arrow = () => console.log(this.firstName);
		arrow();
	}
}
user1.sayHi();

function User(name)
{
	this.name = name;
	this.isAdmin = false;
}

let tom = User("Tom");

function BigUser()
{
	// {}
	this.name = "BigUser";
	//return this;
	return;
}

console.log(new BigUser);
// ? :  if-else
	
let a = prompt("Value");
console.log(a > 10 ? "a>10" : "a<10");