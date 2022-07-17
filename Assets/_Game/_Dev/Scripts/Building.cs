using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Building : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vCam;
    [SerializeField] BuildingInfo info;
    [SerializeField] BuildingSO buildingSO;
    [SerializeField] bool isAlwaysOpen;

    bool _hasBeenOpened;

    private void Start()
    {
        info.SetBuildingInfo(buildingSO.name, buildingSO.description);
        info.ResetPanel();
    }

    void ShowInteraction()
    {
        if (!isAlwaysOpen && _hasBeenOpened) return;

        StateManager.instance.cameraController.ChangeMainVCam(vCam);

        LeanTween.delayedCall(0.5f, () =>
        {
            info.ShowInfo();
        });

    }
    void HideInteraction()
    {
        StateManager.instance.cameraController.ReturnToMainVCam();
        info.HideInfo();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShowInteraction();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HideInteraction();
        }
    }
}
