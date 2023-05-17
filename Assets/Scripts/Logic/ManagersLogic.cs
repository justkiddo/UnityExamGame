using UnityEngine;
using UnityEngine.UI;

public class ManagersLogic : MonoBehaviour
{
    [SerializeField] private Button buyLemonManagerButton;
    [SerializeField] private Button buyPaperManagerButton;
    private bool _boughtLemonManager = false;
    private bool _boughtPaperManager = false;
    private Image _lemonImage;
    private Image _paperImage;
    
    private void Awake()
    {
        _lemonImage = buyLemonManagerButton.GetComponent<Image>();
        _paperImage = buyPaperManagerButton.GetComponent<Image>();
        buyLemonManagerButton.onClick.AddListener(BuyLemonManager);
        buyPaperManagerButton.onClick.AddListener(BuyPaperManager);
    }

    private void Update()
    {
        LemonManagerBoughtCheck();
        PaperManagerBoughtCheck();
        LemonManagerMultiplier();
        PaperManagerMultiplier();
    }

    private void LemonManagerMultiplier()
    {
        if (_boughtLemonManager == true)
        {
            MoneyLogic.money += CareerLogic.LemonPlusMoney * Time.deltaTime;
        }
    }
    private void PaperManagerMultiplier()
    {
        if (_boughtPaperManager == true)
        {
            MoneyLogic.money += CareerLogic.PaperPlusMoney * Time.deltaTime;
        }
    }
    private void LemonManagerBoughtCheck()
    {
        if (_boughtLemonManager == false && MoneyLogic.money < 500f)
        {
            _lemonImage.color = Color.grey;
        }
        else if (_boughtLemonManager == false && MoneyLogic.money >= 500)
        {
            _lemonImage.color = Color.white;
        }
        else if (_boughtLemonManager == true)
        {
            _lemonImage.color = Color.red;
        }
    }
    private void PaperManagerBoughtCheck()
    {
        if (_boughtPaperManager == false && MoneyLogic.money < 10000f)
        {
            _paperImage.color = Color.grey;
        }
        else if (_boughtPaperManager == false && MoneyLogic.money >= 10000f)
        {
            _paperImage.color = Color.white;
        }
        else if (_boughtPaperManager == true)
        {
            _paperImage.color = Color.red;
        }
    }

    private void BuyLemonManager()
    {
        if (MoneyLogic.money >= 500f && _boughtLemonManager == false)
        {
            MoneyLogic.money -= 500;
            _boughtLemonManager = true;
        }
    }
    private void BuyPaperManager()
    {
        if (MoneyLogic.money >= 10000f && _boughtPaperManager == false)
        {
            MoneyLogic.money -= 10000f;
            _boughtPaperManager = true;
        }
    }
}
