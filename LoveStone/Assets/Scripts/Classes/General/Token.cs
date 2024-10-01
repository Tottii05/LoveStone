using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Token : Fighter
{
    public int Position;
    public CharacterSO Character;
    // Start is called before the first frame update
    public void AssignInfo()
    {
        GameManagerScript.gameManager.Token.GetComponentsInChildren<Image>()[2].sprite = Character.sprite;
        GameManagerScript.gameManager.Token.GetComponentsInChildren<Text>()[0].text = "" + Character.Damage;
        GameManagerScript.gameManager.Token.GetComponentsInChildren<Text>()[1].text = "" + Character.HP; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
