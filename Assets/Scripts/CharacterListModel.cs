using System;
using UnityEngine;

[Serializable]
public class CharacterListModel
{
    [SerializeField] private CharacterData[] _characters;

    private int _currentIndex;

    public event Action CurrentCharacterChanged;

    public CharacterData GetCurrent() =>
        _characters[_currentIndex];

    public void SetNext()
    {
        _currentIndex++;
        _currentIndex %= _characters.Length;

        CurrentCharacterChanged?.Invoke();
    }

    public void SetPrevious()
    {
        _currentIndex--;

        if (_currentIndex < 0)
            _currentIndex = _characters.Length - 1;

        CurrentCharacterChanged?.Invoke();
    }
}
