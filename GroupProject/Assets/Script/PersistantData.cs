using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantData : MonoBehaviour
{
    
    [SerializeField] int playerScore;
    [SerializeField] int playerWaste;

    
    public static PersistantData Instance; 

    // Start is called before the first frame update
    void Start()
    {
        
        playerScore = 0;
        playerWaste = 0;
        
    }

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(gameObject);
    }

    

    public void SetScore(int s)
    {
        playerScore = s;
    }

    

    public int GetScore()
    {
        return playerScore;
    }

    public int GetWaste(){
        return playerWaste;
    }

    public void SetWaste(int s){
        playerWaste = s;
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
