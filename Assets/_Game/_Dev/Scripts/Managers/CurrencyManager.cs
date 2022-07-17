using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Sell, Buy }
public class CurrencyManager : MonoBehaviour
{
    private int _coinsAmount;

    public void SellObject(int _amount)
    {
        _coinsAmount += _amount;
    }

    public bool BuyObject(int _amount)
    {
        if (_amount > _coinsAmount)
        {
            return false;
        }
        else
        {
            _coinsAmount -= _amount;
            return true;
        }
    }
}
