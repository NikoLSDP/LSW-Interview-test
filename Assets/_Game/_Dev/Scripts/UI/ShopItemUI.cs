using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItemUI : MonoBehaviour
{

    [SerializeField] Image iconIMG;
    [SerializeField] TextMeshProUGUI priceTMP;
    [SerializeField] Button itemBtn;

    bool _isAvailable;

    public Gargement gargement;

    private void Start()
    {
        SetItemInfo();
    }

    public void SetItemInfo(Gargement _gargement = null, bool _beenBought = false)
    {
        if (_gargement != null)
        {
            gargement = _gargement;
        }

        gargement.SetAllInfo();

        if (!_beenBought)
        {
            _isAvailable = true;
            priceTMP.text = "$ " + gargement.price.ToString();
        }
        else
        {
            DisableItem();
        }

        iconIMG.sprite = gargement.icon;
    }

    public void BuyItem()
    {
        if (!_isAvailable) return;

        BounceBtn();
        ClothesManager.instance.WearNewGargement(gargement);
        DisableItem();
    }

    void DisableItem()
    {
        _isAvailable = false;
        priceTMP.text = "Owned";
        itemBtn.enabled = false;
    }

    void BounceBtn()
    {
        LeanTween.cancel(itemBtn.gameObject);
        LeanTween.scale(itemBtn.gameObject, Vector2.one, 0f);
        LeanTween.scale(itemBtn.gameObject, Vector2.one * 1.2f, 0.3f).setEaseOutBack();
    }
}
