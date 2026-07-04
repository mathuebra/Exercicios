using System;
using System.Xml;

//Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;

        // salva os filhos originais ANTES de mexer neles
        TreeNode originalLeft = root.left;
        TreeNode originalRight = root.right;

        // inverte recursivamente as subárvores
        root.left = InvertTree(originalRight);
        root.right = InvertTree(originalLeft);

        return root;
    }
}