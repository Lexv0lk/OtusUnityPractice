using System;
using DefaultNamespace;
using UnityEngine;

public class CharacterSelectionController : IDisposable
{
    private CharacterSelectionView characterSelectionView;
    private CharacterListModel _charactersModel;

    public CharacterSelectionController(
        CharacterSelectionView characterSelectionView,
        CharacterListModel charactersModel)
    {
        this.characterSelectionView = characterSelectionView;
        _charactersModel = charactersModel;
        OnEnable();
    }

    private void OnEnable()
    {
        characterSelectionView.LeftArrowClick.AddListener(OnLeftArrowClicked);
        characterSelectionView.RightArrowClick.AddListener(OnRightArrowClicked);
        characterSelectionView.SelectButtonClick.AddListener(OnCharacterSelected);
    }

    public void Dispose()
    {
        characterSelectionView.LeftArrowClick.RemoveListener(OnLeftArrowClicked);
        characterSelectionView.RightArrowClick.RemoveListener(OnRightArrowClicked);
        characterSelectionView.SelectButtonClick.RemoveListener(OnCharacterSelected);
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