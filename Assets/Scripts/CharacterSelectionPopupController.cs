using System;

namespace DefaultNamespace
{
    public class CharacterSelectionPopupController : IDisposable
    {
        private CharacterView _characterView;
        private ICharacterSelectionPopupPresenter _presenter;

        public CharacterSelectionPopupController(CharacterView characterView,
            ICharacterSelectionPopupPresenter presenter)
        {
            _characterView = characterView;
            _presenter = presenter;

            _presenter.CurrentCharacterChanged += RefreshState;
        }

        private void RefreshState()
        {
            CharacterData currentData = _presenter.GetCurrent();
            _characterView.Show(new CharacterViewPresenter(currentData.Name, currentData.Icon));
        }

        public void Dispose()
        {
            _presenter.CurrentCharacterChanged -= RefreshState;
        }
    }
}