using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void Quit_()
    {
        Application.Quit();
        Debug.Log("se ha salido del juego");
    }
}
