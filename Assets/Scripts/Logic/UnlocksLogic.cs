using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnlocksLogic : MonoBehaviour
{
    [SerializeField] private Button buyLemonUnlockButton;
    [SerializeField] private Button buyPaperUnlockButton;
    private bool _boughtLemonUnlock;
    private bool _boughtPaperUnlock;
    private bool _buyLemonUnlock = false;
    private bool _buyPaperUnlock = false;
    private Image _lemonImage;
    private Image _paperImage;
    
    
    private void Awake()
    {
        _lemonImage = buyLemonUnlockButton.GetComponent<Image>();
        _paperImage = buyPaperUnlockButton.GetComponent<Image>();
        buyLemonUnlockButton.onClick.AddListener(BuyLemonUnlock);
        buyPaperUnlockButton.onClick.AddListener(BuyPaperUnlock);
    }
    
    private void Update()
    {
        LemonUnlockBoughtCheck();
        PaperUnlockBoughtCheck();
        LemonUnlockBought();
        PaperUnlockBought();
    }
    
    private void LemonUnlockBought()
    {
        if (_boughtLemonUnlock == true && _buyLemonUnlock == false)
        {
            CareerLogic.LemonPlusMoney += 15f;
            _buyLemonUnlock = true;
        }
    }
    
    private void PaperUnlockBought()
    {
        if (_boughtPaperUnlock == true && _buyPaperUnlock == false)
        {
            CareerLogic.PaperPlusMoney += 25f;
            _buyPaperUnlock = true;
        }
    }
    
    private void BuyPaperUnlock()
    {
        if (_boughtPaperUnlock == false && MoneyLogic.money >= 15000f)
        {
            MoneyLogic.money -= 15000f;
            _boughtPaperUnlock = true;
        }
    }
    
    private void BuyLemonUnlock()
    {
        if (_boughtLemonUnlock == false && MoneyLogic.money >= 5000f)
        {
            MoneyLogic.money -= 5000f;
            _boughtLemonUnlock = true;
        }
    }
    
    private void LemonUnlockBoughtCheck()
    {
        if (_boughtLemonUnlock == false && MoneyLogic.money < 5000f)
        {
            _lemonImage.color = Color.gray;
        }else if (_boughtLemonUnlock == false && MoneyLogic.money >= 5000f)
        {
            _lemonImage.color = Color.white;
        }
        else if(_boughtLemonUnlock == true)
        {
            _lemonImage.color = Color.red;
        }
    }
    
    private void PaperUnlockBoughtCheck()
    {
        if (_boughtPaperUnlock == false && MoneyLogic.money < 5000f)
        {
            _paperImage.color = Color.gray;
        }else if (_boughtPaperUnlock == false && MoneyLogic.money >= 5000f)
        {
            _paperImage.color = Color.white;
        }
        else if(_boughtPaperUnlock == true)
        {
            _paperImage.color = Color.red;
        }
    }
    
}
