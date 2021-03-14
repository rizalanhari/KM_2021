using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitCoin : MonoBehaviour
{
    public Text coinText;
    int totalCoin = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("coin"))
        {
            totalCoin++;
            UpdateStarText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateStarText()
    {
        string coinMessage = "=" + totalCoin;
        coinText.text = coinMessage;
    }
}
