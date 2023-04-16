using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class PlayerSpawner : MonoBehaviour
{
    public List<QuadcopterController> SpawnedPlayers = new List<QuadcopterController>();
    [SerializeField] private QuadcopterController _playerPref;
    private UISetuper _uiSetuper;
    private void Awake()
    {
        _uiSetuper = FindAnyObjectByType<UISetuper>();
        Instantiate(_playerPref, transform.position, Quaternion.identity);
    }
    public void WinGame(QuadcopterController winner)
    {
        int playerNum = 0;
        for (int i = 0; i < SpawnedPlayers.Count; i++)
        {
            if(SpawnedPlayers[i] == winner)
            {
                playerNum = i;
                break;
            }
        }
        FindObjectOfType<IngameMenu>().OpenWinScreen(playerNum);
    }
    public void OnPlayerJoined(PlayerInput input)
    {
        var spawnedPlayer = input.GetComponent<QuadcopterController>();
        SpawnedPlayers.Add(spawnedPlayer);
        _uiSetuper.SpawnGUIForPlayer().Initialize(SpawnedPlayers.Count, spawnedPlayer);
        spawnedPlayer.requestPause += () => FindObjectOfType<IngameMenu>().ToggleMenu();
    }
    public Transform GetSpawnPoint()
    {
        return transform;
    }
}
