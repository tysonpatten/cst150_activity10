namespace Activity_10___Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.add(r.Next(4)); 
                B.add(r.Next(12)); 
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B)); // FIXME - returning one of the sets instead of the union

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A); // FIXME - should be unchanged
            Console.WriteLine("B: " + B);

        }
    }
}
