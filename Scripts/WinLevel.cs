using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    public GameManagerScript gameManager;


    private void OnTriggerEnter()
    {
        
        
            gameManager.WinLevel();
        
    }

}
