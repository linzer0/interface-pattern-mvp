using UI.Base;

namespace UI.Profile
{
    public interface IProfileView : IView
    {
        public void SetPlayerName(string name);
        public void SetPlayerLevel(int level);
    }
}