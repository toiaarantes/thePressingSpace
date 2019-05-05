using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontoImprimir : MonoBehaviour
{
    public Text UIText;
    public GameObject telapontos;
    public float printpontos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        printpontos = telapontos.GetComponent<Player>().PontoTotal;
        UIText.text = printpontos.ToString("f0");
    }
}
