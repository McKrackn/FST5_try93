using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
  public int coin = 0;
  public TextMeshProUGUI textCoins;

  private void Update()
  {
    textCoins.text = coin.ToString();
  }

  private void OnTriggerEnter2D(Collider2D other)
  {

    if (other.transform.tag == "Coin")
    {
      coin += 1;
      other.gameObject.SetActive(false);
    }

  }
}
