using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterView : MonoBehaviour
{
    [SerializeField] private TMP_Text _name;
    [SerializeField] private Image _icon;

    public void Show(ICharacterViewPresenter presenter)
    {
        _name.text = presenter.Name;
        _icon.sprite = presenter.Icon;
    }
}
