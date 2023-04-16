using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISetuper : MonoBehaviour
{
    [SerializeField] PlayerGUI _GUIPref;
    [SerializeField] Transform _GUIContainer;
    public PlayerGUI SpawnGUIForPlayer()
    {
        var newGUI = Instantiate(_GUIPref, _GUIContainer);
        return newGUI;
    }
}
