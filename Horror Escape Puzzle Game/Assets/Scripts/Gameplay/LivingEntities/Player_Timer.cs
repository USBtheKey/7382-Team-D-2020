using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player_Timer : MonoBehaviour
{
    [SerializeField] private float _timerMax = 50f;
    [SerializeField] private bool _isTimerCalcPause = false;
    [SerializeField] private float _curTime = 0;

    public float GetCurTime
    {
        get => _curTime;
    }

    public void StartCalcTime()
    {
        _curTime = _timerMax;
        _isTimerCalcPause = false;
    }
    public void PauseCalcTime(bool flag)
    {
        _isTimerCalcPause = flag;
    }
    private void Start()
    {
        StartCalcTime();
    }
    private void Update()
    {
        if (!_isTimerCalcPause)
        {
            _curTime -= Time.deltaTime;
            if (_curTime <= 0)
            {
                _isTimerCalcPause = true;
                _curTime = 0;
                //todo dead
            }
        }
    }

}