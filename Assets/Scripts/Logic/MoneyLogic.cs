using TMPro;
using UnityEngine;


public class MoneyLogic : MonoBehaviour
{

   [SerializeField] private TextMeshProUGUI moneyText;

   public static float Money = 0f;
   

   private void Update()
   {
      moneyText.text = "Money " + ((int)Money).ToString() + " $";
   }



   public float GetMoney()
   {
      return Money;
   }

   public static void SetMoney(float changeMoney)
   {
      Money = changeMoney;
   }
   
}
