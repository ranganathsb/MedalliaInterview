//给一个BST和一个node，找出BST中所有比这个node的值大的node中值最小的那个
//其实就是in order successor of a given node in BST
//http://www.geeksforgeeks.org/inorder-successor-in-binary-search-tree/


private List<TreeNode> list = new List<TreeNode>();

		public void InOrderFind(TreeNode root)
		{
			if (root == null)
				return;
			if (root.Left != null)
				InOrderFind (root.Left);
			list.Add (root);
			if (root.Right != null)
				InOrderFind (root.Right);

		}

		public TreeNode FindNode(TreeNode root, TreeNode n){
			InOrderFind (root);
			for (int i = 0; i < list.Count; i++) {
				if (list [i] == n)
					return list [i + 1];
			}
		}


//do not use extra memory space

truct node * inOrderSuccessor(struct node *root, struct node *n)
{
    // step 1 of the above algorithm
    if( n->right != NULL )
        return minValue(n->right);
 
    struct node *succ = NULL;
 
    // Start from root and search for successor down the tree
    while (root != NULL)
    {
        if (n->data < root->data)
        {
            succ = root;
            root = root->left;
        }
        else if (n->data > root->data)
            root = root->right;
        else
           break;
    }
 
    return succ;
}
