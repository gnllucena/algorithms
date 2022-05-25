namespace Algorithms.Structures
{
    public class Tree
    {
        public Tree(int data, int? depth = null)
        {
            Data = data;
            Depth = depth;
        }

        public int Data { get; set; }
        public int? Depth { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public static Tree Fill(List<int> array)
        {
            Tree root = null;

            foreach (var item in array)
            {
                root = Insert(root, item);
            }

            return root;
        }

        public static Tree Insert(Tree root, int data)
        {
            if (root == null)
            {
                return new Tree(data);
            }
            else
            {
                Tree current;

                if (data <= root.Data)
                {
                    current = Insert(root.Left, data);
                    root.Left = current;
                }
                else
                {
                    current = Insert(root.Right, data);
                    root.Right = current;
                }

                return root;
            }
        }
    }
}
