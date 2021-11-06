using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text nutritionText;
    private int nutritionPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateNutritionPoint(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void UpdateNutritionPoint(int pointToAdd)
    {
        nutritionPoint += pointToAdd;
        nutritionText.text = "Nutrition Points: " + nutritionPoint;

        Debug.Log(nutritionPoint);
    }
}
