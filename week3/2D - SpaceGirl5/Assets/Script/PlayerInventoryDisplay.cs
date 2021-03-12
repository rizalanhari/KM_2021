using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] starPlaceholders;
    public Sprite iconStarYellow;
    public Sprite animal0;
    public Sprite animal1;
    public Sprite animal2;
    public Sprite animal3;
    public Sprite iconStarGrey;
    public void OnChangeStarTotal(int starTotal, string animal)
    {
        starTotal -= 1;
        if (animal == "animal0")
        {
            starPlaceholders[starTotal].sprite = animal0;
        }
        else if (animal == "animal1")
        {
            starPlaceholders[starTotal].sprite = animal1;
        }
        else if (animal == "animal2")
        {
            starPlaceholders[starTotal].sprite = animal2;
        }
        else if (animal == "animal3")
        {
            starPlaceholders[starTotal].sprite = animal3;
        }
        else
        {

        }

    }
}
