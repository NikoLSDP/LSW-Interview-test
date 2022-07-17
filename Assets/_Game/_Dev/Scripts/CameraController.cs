using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] CinemachineVirtualCamera vCamMain;

    CinemachineVirtualCamera _currentVCam;

    public void ChangeMainVCam(CinemachineVirtualCamera _newVCam)
    {
        _currentVCam = _newVCam;
        _newVCam.Priority = 11;
        vCamMain.Priority = 9;
    }

    public void ReturnToMainVCam()
    {
        _currentVCam.Priority = 9;
        vCamMain.Priority = 11;
        _currentVCam = vCamMain;
    }
}
