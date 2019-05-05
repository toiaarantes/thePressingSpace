using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveNome : MonoBehaviour
{
    public InputField playerName;
    public GameObject foguete;
    private float pontos = 0;
    
    void Start()
    {
        pontos = foguete.GetComponent<Player>().PontoTotal;
    }
    public void InitialsEntered()
    {
        GetComponent<RankingController>().CheckForHighScore(pontos, playerName.text);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
