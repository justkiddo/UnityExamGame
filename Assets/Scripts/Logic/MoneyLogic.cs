using TMPro;
using UnityEngine;


public class MoneyLogic : MonoBehaviour
{

   [SerializeField] private TextMeshProUGUI moneyText;

   public static float money = 0f;
   

   private void Update()
   {
      moneyText.text = "Money " + ((int)money).ToString() + " $";
   }



   public float GetMoney()
   {
      return money;
   }

   public static void SetMoney(float changeMoney)
   {
      money = changeMoney;
   }
   
}
