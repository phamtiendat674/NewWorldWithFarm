using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int fpsGame;
    // Start is called before the first frame update
    void Start()
    {
        //Limit FPS
        Application.targetFrameRate = fpsGame;
    }

    // Update is called once per frame
    void Update()
    {   
       
    }
}
