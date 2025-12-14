//	i. base keyword
// See https://aka.ms/new-console-template for more information

// class parent
// {
//     public int x, y;
//     public void set()
//     {
//         x = 10;
//         y = 20;
//     }
// }
// class child:parent
// {
//     int x, y;
//     public void get()
//     {
//         this.x = base.x;
//         this.y=base.y;
//     }
//     public void put()
//     {
//         Console.WriteLine("x=" + x);
//         Console.WriteLine("y=" + y);
//     }
// }

// class Test
// {
//     static void Main(string[]args)
//     {
//         child obj=new child();
//         obj.set();
//         obj.get();
//         obj.put();
//     }
// }
	//ii. base() method- it is used for calling the base class constructor in the derived class constructor.

// class parent
// {
//     public parent()
//     {
//         Console.WriteLine("First Constrtor of Parent Class");
//     }
//     public parent(int n)
//     {
//         Console.WriteLine("Second Constructor of Parent Class");
//     }
 
// }
// class child:parent
// {
//     public child() : base(10)
//     {
//         Console.WriteLine("Constrctor of Child class");
//     }


// }

// class Test
// {
//     static void Main(string[]args)
//     {
//         child obj=new child();
//     }
// }
