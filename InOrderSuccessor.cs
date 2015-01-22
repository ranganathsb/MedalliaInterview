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
