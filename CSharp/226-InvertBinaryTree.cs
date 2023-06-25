public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        // 遇到空值回傳空值
        if (root == null) 
        {
            return null;
        }

        // 左右資料交換
        TreeNode tempLeft = root.left;
        TreeNode tempRight = root.right;
        root.left = tempRight;
        root.right = tempLeft;

        // 左右邊還有值的話使用遞迴
        if (root.left != null)
        {
            InvertTree(root.left);
        }

        if (root.right != null)
        {
            InvertTree(root.right);
        }

        // 結果
        return root;
    }
}