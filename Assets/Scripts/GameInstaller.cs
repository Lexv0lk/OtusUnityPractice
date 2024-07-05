using UnityEngine;

namespace DefaultNamespace
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private CharacterSelectionView characterSelectionView;
        [SerializeField] private CharacterSelectionPopupView selectionPopupView;
        [SerializeField] private CharacterView characterView;

        [SerializeField] private CharacterListModel characterListModel;

        private CharacterSelectionController _selectionController;
        private CharacterSelectionPopupController _characterSelectionPopupController;

        private void OnEnable()
        {
            _selectionController =
                new CharacterSelectionController(characterSelectionView, characterListModel);

            _characterSelectionPopupController =
                new CharacterSelectionPopupController(characterView,
                    new CharacterSelectionPopupPresenter(characterListModel));
        }

        private void OnDisable()
        {
            _selectionController.Dispose();
        }
    }
}