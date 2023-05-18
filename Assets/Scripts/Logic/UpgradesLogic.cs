using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesLogic : MonoBehaviour
{
    [SerializeField] private Button lemonUpgradeButton;
    [SerializeField] private Button paperUpgradeButton;
    private bool _boughtLemon = false;
    private bool _boughtPaper = false;
    private Image _lemonImage;
    private Image _paperImage;
    
    
    private void Awake()
    {
        lemonUpgradeButton.onClick.AddListener(BuyLemonUpgrade);
        paperUpgradeButton.onClick.AddListener(BuyPaperUpgrade);
        _lemonImage = lemonUpgradeButton.GetComponent<Image>();
        _paperImage = paperUpgradeButton.GetComponent<Image>();
    }

    private void Update()
    {
        LemonUpgradeBoughtCheck();
        PaperUpgradeBoughtCheck();
        LemonUpgradeBought();
        PaperUpgradeBought();
        
        
    }

    private void LemonUpgradeBought()
    {
        if (_boughtLemon == true)
        {
            CareerLogic.LemonPlusMoney *= 3f;
        }
    }
    
    private void PaperUpgradeBought()
    {
        if (_boughtPaper == true)
        {
            CareerLogic.PaperPlusMoney *= 3f;
        }
    }

    private void BuyLemonUpgrade()
    {
        if (_boughtLemon == false && MoneyLogic.money >= 250000f)
        {
            MoneyLogic.money -= 250000f;
            _boughtLemon = true;
        }
    }
    
    private void BuyPaperUpgrade()
    {
        if (_boughtPaper == false && MoneyLogic.money >= 500000f)
        {
            MoneyLogic.money -= 500000f;
            _boughtPaper = true;
        }
    }

    private void LemonUpgradeBoughtCheck()
    {
        if (_boughtLemon == false && MoneyLogic.money < 250000f)
        {
            _lemonImage.color = Color.gray;
        }else if (_boughtLemon == false && MoneyLogic.money >= 250000f)
        {
            _lemonImage.color = Color.white;
        }
        else if(_boughtLemon == true)
        {
            _lemonImage.color = Color.red;
        }
    }
    private void PaperUpgradeBoughtCheck()
    {
        if (_boughtPaper == false && MoneyLogic.money < 250000f)
        {
            _paperImage.color = Color.gray;
        }else if (_boughtPaper == false && MoneyLogic.money >= 250000f)
        {
            _paperImage.color = Color.white;
        }
        else if(_boughtPaper == true)
        {
            _paperImage.color = Color.red;
        }
    }
    
    
}
