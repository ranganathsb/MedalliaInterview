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
Parent pointer is NOT needed in this algorithm. The Algorithm is divided into two cases on the basis of right subtree of the input node being empty or not.

Input: node, root // node is the node whose Inorder successor is needed.
output: succ // succ is Inorder successor of node.

1) If right subtree of node is not NULL, then succ lies in right subtree. Do following.
Go to right subtree and return the node with minimum key value in right subtree.
2) If right sbtree of node is NULL, then start from root and us search like technique. Do following.
Travel down the tree, if a node’s data is greater than root’s data then go right side, otherwise go to left side.


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
