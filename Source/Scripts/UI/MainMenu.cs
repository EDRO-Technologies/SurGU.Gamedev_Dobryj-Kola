using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainMenu : MonoBehaviour
{
    public void LoadLevel(int level)
    {
        MapLoader.LoadLevel(level);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
