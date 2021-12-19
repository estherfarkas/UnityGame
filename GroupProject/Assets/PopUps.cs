using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUps : MonoBehaviour
{
    [SerializeField] GameObject popUp;
    [SerializeField] Text popUpText;
    [SerializeField] int nextPopUp;
    string [] popUps;
    bool popUpTriggered;
    int arrayValue;
    // Start is called before the first frame update
    void Start()
    {
        popUp.SetActive(false);

        string pop1 = "Did you know? Every year over 108 billion pounds of food are wasted in the U.S. alone.";
        string pop2 = "Did you know? The most commonly wasted foods are fruits and vegetables";
        string pop3 = "Food Tip: eat foods with a shorter shelf-life first, in order to gain the maximum amount of points";
        string pop4 = "Food Tip: taking inventory and having a shopping list can prevent over-buying";
        string pop5 = "Did you know? Reducing food waste can save money and conserve resources";

        popUps= new string [] {pop1, pop2, pop3, pop4, pop5};
        nextPopUp = 40;
        popUpTriggered = false;
        arrayValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (popUpTriggered == false){
            if (PersistantData.Instance.GetScore() >= nextPopUp && arrayValue< popUps.Length){
                 Debug.Log("PopUp triggered");
                makePopUp(nextPopUp);
                nextPopUp = nextPopUp + 35;

        }
        }
        
    }

    public void makePopUp(float nextPopUp){
            popUpText.text = popUps[arrayValue];
            popUp.SetActive(true);  
            popUpTriggered = true;  
            arrayValue ++; 
            Time.timeScale = 0;   
    }

     public void escapePopUp(){
        popUp.SetActive(false);
        popUpTriggered = false;
        Time.timeScale = 1;
    }

}
