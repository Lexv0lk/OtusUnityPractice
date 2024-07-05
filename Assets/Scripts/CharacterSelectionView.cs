using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class CharacterSelectionView : MonoBehaviour
    {
        [SerializeField] private Button _leftArrow;
        [SerializeField] private Button _rightArrow;
        [SerializeField] private Button _selectButton;

        // public event UnityAction LeftArrowClick;
        // public event UnityAction RightArrowClick;
        // public event UnityAction CharacterSelectedClick;

        public Button.ButtonClickedEvent LeftArrowClick => _leftArrow.onClick;
        public Button.ButtonClickedEvent RightArrowClick => _rightArrow.onClick;
        public Button.ButtonClickedEvent SelectButtonClick => _selectButton.onClick; }
}