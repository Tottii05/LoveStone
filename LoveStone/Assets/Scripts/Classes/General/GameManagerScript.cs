using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject Spell, Char, Avatar, Power, Token, Designer;
    public static GameManagerScript gameManager;
    // Start is called before the first frame update
    private void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManager = this;
        }
    }
}
