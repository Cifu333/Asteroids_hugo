using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    public int punt;
    public int life;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
