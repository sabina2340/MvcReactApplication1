namespace MvcApplicaTion3.Server.Models
{
    public class TreeNode
    {
        
            public string Text { get; set; }
            public string Name { get; set; }

            public int Id { get; set; }
            public List<TreeNode> Nodes { get; set; }

            public TreeNode()
            {
                Nodes = new List<TreeNode>();
            }
        
    }
}
