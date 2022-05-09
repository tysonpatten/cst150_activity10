namespace Activity_10___Debugging
{

    //Lydia's code - find the errors!
    class Set
    {

        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        
        public bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                // no need for else statement because it will return false if the value is not in the list
                // else
                // return false;
            }
            return false;
        }

        
        // changed from bool return to void because it doesn't need to return anything
        public void addElement(int val)
        {
            // took out returns
            // changed to !containsElement(val) because easier to formulate if statement
            if (!containsElement(val)) //return false; 
            //else
            {
                elements.Add(val);
                //return true;
            }
        }

        
        // added this element so that we could add 10 elements to each set
        public void add(int val)
        {
            {
                elements.Add(val);
                
            }
        }


        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        
        public void clearSet()
        {
            elements.Clear();
        }


        public Set union(Set rhs)
        {
            // needed to create new set to return instead of modifying this set
            Set newSet = new Set();

            for (int i = 0; i < elements.Count; i++)
            {
                newSet.addElement(elements[i]);
            }


            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // needed to change to newSet.addElement because it was adding to this set
                //this.addElement(rhs.elements[i]); 
                newSet.addElement(rhs.elements[i]);
            }

            // implemented a sort for union structure
            newSet.elements.Sort();

            // changed return to the new set
            // return rhs;
            return newSet;
        }

    }
}



