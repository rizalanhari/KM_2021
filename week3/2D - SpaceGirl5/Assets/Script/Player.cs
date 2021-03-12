using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalStars = 0;
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Animal0"))
        {
            totalStars++;
            playerInventoryDisplay.OnChangeStarTotal(totalStars, "animal0");
            Destroy(hit.gameObject);
        }
        else if (hit.CompareTag("Animal1"))
        {
            totalStars++;
            playerInventoryDisplay.OnChangeStarTotal(totalStars, "animal1");
            Destroy(hit.gameObject);
        }
        else if (hit.CompareTag("Animal2"))
        {
            totalStars++;
            playerInventoryDisplay.OnChangeStarTotal(totalStars, "animal2");
            Destroy(hit.gameObject);
        }
        else if (hit.CompareTag("Animal3"))
        {
            totalStars++;
            playerInventoryDisplay.OnChangeStarTotal(totalStars, "animal3");
            Destroy(hit.gameObject);
        }
        else
        {

        }
    }
}
