using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerGUI : MonoBehaviour
{
    [SerializeField] TMP_Text _playerIdText;
    [SerializeField] TMP_Text _throttleText;
    [Header("Drone health")]
    [SerializeField] TMP_Text _FRStateText;
    [SerializeField] TMP_Text _FLStateText;
    [SerializeField] TMP_Text _BRStateText;
    [SerializeField] TMP_Text _BLStateText;
    [SerializeField] TMP_Text _PIDpitch;
    [SerializeField] TMP_Text _PIDyaw;
    [SerializeField] TMP_Text _PIDroll;
    [SerializeField] TMP_Text _PIDHeight;
    [SerializeField] TMP_Text _scoreText;
    QuadcopterController _copter;
    private int _playerId = 0;
    public void Initialize(int playerId, QuadcopterController copter)
    {
        _playerId = playerId;
        _playerIdText.text = "Player " + _playerId;
        _copter = copter;
    }
    private void Update()
    {
        UpdateStats();
    }
    public void UpdateStats()
    {
        _FRStateText.text = "FR\n" + _copter.propellerFR.health;
        _FLStateText.text = "FL\n" + _copter.propellerFL.health;
        _BRStateText.text = "BR\n" + _copter.propellerBR.health;
        _BLStateText.text = "BL\n" + _copter.propellerBL.health;
        _PIDpitch.text = "P" + _copter.PID_pitch_gains.ToString("F1");
        _PIDyaw.text = "Y" + _copter.PID_yaw_gains.ToString("F1");
        _PIDroll.text = "R" + _copter.PID_roll_gains.ToString("F1");
        _PIDHeight.text = "T" + _copter.PID_throttleGains.ToString("F1");
        _throttleText.text = "Throttle: " + _copter.throttle.ToString("F1");
        _scoreText.text = "Score: " + _copter.Score.ToString();
    }
}
