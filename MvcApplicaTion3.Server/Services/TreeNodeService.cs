using MvcApplicaTion3.Server.Services.Interfaces;

namespace MvcApplicaTion3.Server.Services
{
        public class TreeNodeService : ITreeNodeService
        {
            private List<TreeNode> _treeNodes = new List<TreeNode>();

            public TreeNode Create(TreeNode model)
            {
                _treeNodes.Add(model);
                return model;
            }

            public TreeNode Update(TreeNode model)
            {
               
                var existingNode = _treeNodes.FirstOrDefault(n => n.Name == model.Name);
                if (existingNode != null)
                {
                    existingNode.Text = model.Text;
                }

                return existingNode;
            }

            public TreeNode Get(int id)
            {
                return _treeNodes.FirstOrDefault(n => n.Id == id);
            }

            public IEnumerable<TreeNode> GetAll()
            {
                return _treeNodes;
            }

            public void Delete(int id)
            {
                _treeNodes.RemoveAll(n => n.Id == id);
            }
        }
    
}
