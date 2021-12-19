using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    [SerializeField] Text score;
    [SerializeField] Text wasteFood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:  " + PersistantData.Instance.GetScore();
        wasteFood.text = "Food Wasted: " + PersistantData.Instance.GetWaste();
    }
}
