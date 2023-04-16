using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMenu : MonoBehaviour
{
    [SerializeField] GameObject _tutorialContainer;
    [SerializeField] GameObject _menuContainer;
    [SerializeField] GameObject _winScreen;
    [SerializeField] TMPro.TMP_Text _winscreenText;
    public void ToggleMenu()
    {
        _menuContainer.SetActive(!_menuContainer.activeSelf);
        PauseController.Pause(_menuContainer.activeSelf);
        _tutorialContainer.SetActive(false);
    }
    public void OpenMainMenu()
    {
        PauseController.Pause(true);
        MapLoader.LoadMainMenu();
    }
    public void OpenTutorial()
    {
        PauseController.Pause(true);
        _tutorialContainer.SetActive(true);
    }
    public void OpenWinScreen(int playerWon)
    {
        PauseController.Pause(true);
        _winScreen.SetActive(true);
        _winscreenText.text = "Player " + (playerWon + 1) + " won!";
    }
}
