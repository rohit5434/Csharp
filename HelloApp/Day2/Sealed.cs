// 4. sealed
// 	i. sealed class - we can not inherit a sealed class
// 	ii. sealed method- we can not override a sealed method

// Method overriding

// class Parent
// {
//     public virtual void thinking()
//     {
//         Console.WriteLine("Parent Thinking is old school");
//     }
// }
// class Child:Parent
// {
//     public override void thinking()
//     {
//         Console.WriteLine("We are in modern era");
//     }
// }
// class Test
// {
//     static void Main(string[]args)
//     {
//         Parent pobj;
//         pobj=new Child();
//         pobj.thinking();

//     }
// }
