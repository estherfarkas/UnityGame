using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text nutritionText;
<<<<<<< Updated upstream
=======
    public Text wasterCounterText;

    public Text timerText;

>>>>>>> Stashed changes
    private int nutritionPoint = 0;

    public float timeRemaining = 60;

    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        UpdateNutritionPoint(0);
    }

    // Update is called once per frame
    void Update()
    {
         

        UpdateTime();
    }

   public void UpdateNutritionPoint(int pointToAdd)
    {
        nutritionPoint += pointToAdd;
        nutritionText.text = "Nutrition Points: " + nutritionPoint;

        Debug.Log(nutritionPoint);
    }
<<<<<<< Updated upstream
=======

    public void UpdateWasteCounter()
    {
        wasteCounter += 1;
        wasterCounterText.text = "Waste Food: " + wasteCounter;

    }

    public void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);

    }

    public void GameOver()
    {

    }

    public void UpdateTime()
    {
        
        Mathf.Clamp(timeRemaining, 0.0f,60.0f);

        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time left: " + timeRemaining;
        }

        else
        {
            GameOver();
        }
    }

    
>>>>>>> Stashed changes
}
