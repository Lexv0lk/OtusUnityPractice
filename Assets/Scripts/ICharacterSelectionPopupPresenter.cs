using System;

public interface ICharacterSelectionPopupPresenter
{
    event Action CurrentCharacterChanged;
    CharacterData GetCurrent();
}