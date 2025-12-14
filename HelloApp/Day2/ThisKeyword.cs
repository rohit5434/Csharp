// 1. this
// 	a) this keyword- reference as an object of the class in which it is used.
// 	b) this() - it is used for calling the constructor of class inside the another constructor
//      of the same class.

// class cons
// {
//     public cons():this(10)
//     {
//         Console.WriteLine("First Constructor");
//     }
//     public cons(int x)
//     {
//         Console.WriteLine("Second Constrtcor");
//         Console.WriteLine("value of x " +x);
//     }
// }
// class Test
// {
//     static void Main(string[]args)
//     {
//             cons obj=new cons();
//     }
// }
