using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionController : MonoBehaviour
{
    [SerializeField] private Button _leftArrow;
    [SerializeField] private Button _rightArrow;
    [SerializeField] private Button _selectButton;
    [SerializeField] private CharacterSelectionPopup _selectionPopup;
    [SerializeField] private CharacterListModel _charactersModel;

    private void OnEnable()
    {
        _leftArrow.onClick.AddListener(OnLeftArrowClicked);
        _rightArrow.onClick.AddListener(OnRightArrowClicked);
        _selectButton.onClick.AddListener(OnCharacterSelected);
    }

    private void OnDisable()
    {
        _leftArrow.onClick.RemoveListener(OnLeftArrowClicked);
        _rightArrow.onClick.RemoveListener(OnRightArrowClicked);
        _selectButton.onClick.RemoveListener(OnCharacterSelected);
    }

    private void Start()
    {
        ShowSelectionPopup();
    }

    public void ShowSelectionPopup()
    {
        _selectionPopup.Show(new CharacterSelectionPopupPresenter(_charactersModel));
    }

    private void OnLeftArrowClicked()
    {
        _charactersModel.SetPrevious();
    }

    private void OnRightArrowClicked()
    {
        _charactersModel.SetNext();
    }

    private void OnCharacterSelected()
    {
        Debug.Log(_charactersModel.GetCurrent().Name);
    }
}
