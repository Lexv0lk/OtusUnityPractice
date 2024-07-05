using UnityEngine;

public class CharacterViewPresenter : ICharacterViewPresenter
{
    private readonly string _name;
    private readonly Sprite _icon;

    public CharacterViewPresenter(string name, Sprite icon)
    {
        _name = name;
        _icon = icon;
    }

    string ICharacterViewPresenter.Name => _name;
    Sprite ICharacterViewPresenter.Icon => _icon;
}
