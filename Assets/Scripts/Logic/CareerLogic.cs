using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CareerLogic : MonoBehaviour
{
    [SerializeField] private Button buyFirstPassiveUpgradeButton;
    [SerializeField] private Button buySecondPassiveUpgradeButton;
    [SerializeField] private Button sellLemonButton;
    [SerializeField] private Image lemonProgressImage;
    [SerializeField] private Button sellPaperButton;
    [SerializeField] private Image paperProgressImage;

    public static float LemonPlusMoney = 1f;
    public static float PaperPlusMoney = 2f;
    
    private int _lemonClicks = 0;
    private int _paperClicks = 0;
    private bool _paperUpgrade = false;
    
    private void Awake()
    {
        sellLemonButton.onClick.AddListener(SellLemon);
        sellPaperButton.onClick.AddListener(SellPaper);
        buyFirstPassiveUpgradeButton.onClick.AddListener(SellLemonUpgrade);
        buySecondPassiveUpgradeButton.onClick.AddListener(SellPaperUpgrade);
    }
    

    private void SellLemon()
    {
        MoneyLogic.Money += LemonPlusMoney ;
    }

    private void SellPaper()
    {
        if (_paperUpgrade == true)
        {
            MoneyLogic.Money += PaperPlusMoney;
        }
    }
    
    private void SellLemonUpgrade()
    {
        if (MoneyLogic.Money >= 30f)
        {
            lemonProgressImage.fillAmount += _lemonClicks * 0.1f;
            MoneyLogic.Money -= 30f;
            LemonPlusMoney += 1f;
            _lemonClicks++;
            if (lemonProgressImage.fillAmount >= 1f)
            {
                MoneyLogic.Money += 7f;
                lemonProgressImage.fillAmount = 0;
                _lemonClicks = 0;
            }
        }
    }
    
    private void SellPaperUpgrade()
    {
        if (MoneyLogic.Money >= 60f)
        {
            _paperUpgrade = true;
            paperProgressImage.fillAmount += _paperClicks * 0.1f;
            MoneyLogic.Money -= 60f;
            PaperPlusMoney += 2f;
            _paperClicks++;
            if (paperProgressImage.fillAmount >= 1f)
            {
                MoneyLogic.Money += 7f;
                paperProgressImage.fillAmount = 0;
                _paperClicks = 0;
            }
        }
    }
    
}
