using UI.Base;

namespace UI.Profile
{
    public interface IProfileView : IView
    {
        public void SetName(string playerName);
    }
}