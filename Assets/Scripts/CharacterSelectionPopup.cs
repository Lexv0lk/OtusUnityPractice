using UnityEngine;

public class CharacterSelectionPopup : MonoBehaviour
{
    [SerializeField] private CharacterView _characterView;

    private ICharacterSelectionPopupPresenter _presenter;

    public void Show(ICharacterSelectionPopupPresenter presenter)
    {
        _presenter = presenter;
        _presenter.CurrentCharacterChanged += RefreshState;
    }

    private void RefreshState()
    {
        CharacterData currentData = _presenter.GetCurrent();
        _characterView.Show(new CharacterViewPresenter(currentData.Name, currentData.Icon));
    }

    public void Hide()
    {
        _presenter.CurrentCharacterChanged -= RefreshState;
    }
}