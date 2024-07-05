using System;

public class CharacterSelectionPopupPresenter : ICharacterSelectionPopupPresenter
{
    private readonly CharacterListModel _model;

    event Action ICharacterSelectionPopupPresenter.CurrentCharacterChanged
    {
        add
        {
            _model.CurrentCharacterChanged += value;
        }

        remove
        {
            _model.CurrentCharacterChanged -= value;
        }
    }

    public CharacterSelectionPopupPresenter(CharacterListModel model)
    {
        _model = model;
    }

    CharacterData ICharacterSelectionPopupPresenter.GetCurrent()
    {
        return _model.GetCurrent();
    }
}
