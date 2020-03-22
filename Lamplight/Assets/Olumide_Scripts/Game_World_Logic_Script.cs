using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Game_World_Logic_Script : MonoBehaviour
{
    public UnityEvent endGame;
    public UnityEvent laternLit;

    // Start is called before the first frame update
    void Start()
    {
        endGame.AddListener(EndGame);
        laternLit.AddListener(LaternLit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndGame()
    {

    }

    void LaternLit()
    {

    }
}
