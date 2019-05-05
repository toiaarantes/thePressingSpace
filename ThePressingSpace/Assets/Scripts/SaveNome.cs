using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveNome : MonoBehaviour
{
    public InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void InitialsEntered()
    {
        GetComponent<RankingController>().CheckForHighScore(PontoTotal, playerName.text);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
