using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagersLogic : MonoBehaviour
{
    [SerializeField] private Button buyLemonManagerButton;
    [SerializeField] private Button buyPaperManagerButton;
    private bool _boughtLemonManager;
    private bool _boughtPaperManager;
    private Image _lemonImage;
    private Image _paperImage;
    [SerializeField] private TextMeshProUGUI lemonPlusInfo;
    [SerializeField] private TextMeshProUGUI paperPlusInfo;

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
        LemonInfo();
        PaperInfo();
    }

    private void LemonInfo()
    {
        if (_boughtLemonManager)
        {
            lemonPlusInfo.text = "+" + CareerLogic.LemonPlusMoney + " per click";
        }
    }

    private void PaperInfo()
    {
        if (_boughtPaperManager)
        {
            paperPlusInfo.text = "+" + CareerLogic.PaperPlusMoney + " per click";
        }
    }

    private void LemonManagerMultiplier()
    {
        if (_boughtLemonManager)
        {
            MoneyLogic.money += CareerLogic.LemonPlusMoney * Time.deltaTime;
        }
    }
    private void PaperManagerMultiplier()
    {
        if (_boughtPaperManager)
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
