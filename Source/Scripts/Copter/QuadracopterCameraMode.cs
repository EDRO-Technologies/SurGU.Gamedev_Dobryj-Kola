using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadracopterCameraMode : MonoBehaviour
{
    [SerializeField] Camera _cam;
    [SerializeField] Transform _fpvPos;
    [SerializeField] Transform _tpsPos;
    private bool _fpv = false;
    private void Start()
    {
        //_cam.transform.SetParent(null, false);
    }
    private void Update()
    {
        //if(_cam.Follow != transform || _cam.LookAt != transform)
        //{
        //    _cam.Follow = transform;
        //    _cam.LookAt = transform;
        //}
    }
    public void OnCameraChangeMode()
    {
        ChangeFPV();
    }
    private void ChangeFPV()
    {
        if(_fpv)
        {
            _cam.transform.SetParent(_tpsPos, false);
            CamReset();
            _fpv = false;
        }
        else
        {
            _fpv = true;
            _cam.transform.SetParent(_fpvPos, false);
            CamReset();
        }
    }
    private void CamReset()
    {
        _cam.transform.localPosition = Vector3.zero;
        _cam.transform.localRotation = new Quaternion();

    }
}
