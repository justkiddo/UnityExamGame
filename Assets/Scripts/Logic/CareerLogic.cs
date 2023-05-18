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
    public static float PaperPlusMoney = 3f;
    
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
    
    private void Update()
    {
    }


    
    private void SellLemon()
    {
        MoneyLogic.money += LemonPlusMoney;
    }

    private void SellPaper()
    {
        if (_paperUpgrade == true)
        {
            MoneyLogic.money += PaperPlusMoney;
        }
    }
    
    private void SellLemonUpgrade()
    {
        if (MoneyLogic.money >= 30f)
        {
            lemonProgressImage.fillAmount += _lemonClicks * 0.1f;
            MoneyLogic.money -= 30f;
            LemonPlusMoney += 1f;
            _lemonClicks++;
        }
    }
    
    private void SellPaperUpgrade()
    {
        if (MoneyLogic.money >= 60f)
        {
            _paperUpgrade = true;
            paperProgressImage.fillAmount += _paperClicks * 0.1f;
            MoneyLogic.money -= 60f;
            PaperPlusMoney += 2f;
            _paperClicks++;
        }
    }
    
}
