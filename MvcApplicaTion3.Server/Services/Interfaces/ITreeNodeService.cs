namespace MvcApplicaTion3.Server.Services.Interfaces
{
    public interface ITreeNodeService
    {
        TreeNode Create(TreeNode model);
        TreeNode Update(TreeNode model);
        TreeNode Get(int id);
        IEnumerable<TreeNode> GetAll();
        void Delete(int id);
    }
}
