using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildingInfo : MonoBehaviour
{
    [SerializeField] TextMeshPro nameTMP;
    [SerializeField] TextMeshPro descriptionTMP;

    Transform _tr;

    private void Awake()
    {
        _tr = transform;
    }
    public void SetBuildingInfo(string _name, string _description)
    {
        nameTMP.text = _name;
        descriptionTMP.text = _description;
    }

    public void ResetPanel()
    {
        nameTMP.gameObject.SetActive(false);
        descriptionTMP.gameObject.SetActive(false);
        _tr.localScale = Vector2.zero;
    }

    public void ShowInfo()
    {
        LeanTween.cancel(gameObject);
        nameTMP.gameObject.SetActive(true);
        descriptionTMP.gameObject.SetActive(true);
        LeanTween.scale(gameObject, Vector2.one, 0.3f).setEaseOutBack();
    }

    public void HideInfo()
    {
        LeanTween.cancel(gameObject);
        nameTMP.gameObject.SetActive(false);
        descriptionTMP.gameObject.SetActive(false);
        LeanTween.scale(gameObject, Vector2.zero, 0.2f).setEaseInQuad();
    }
}
