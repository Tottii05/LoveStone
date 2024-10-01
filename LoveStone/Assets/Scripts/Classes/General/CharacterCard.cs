using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CharacterCard : Card
{
    public CharacterSO Character;
    public void Invoke(Token token)
    {

    }
    // Start is called before the first frame update
    public void AssignInfo()
    {
        GameManagerScript.gameManager.Char.GetComponentsInChildren<Text>()[0].text = "" + Mana;
        GameManagerScript.gameManager.Char.GetComponentsInChildren<Text>()[1].text = "" + Character.Damage;
        GameManagerScript.gameManager.Char.GetComponentsInChildren<Text>()[2].text = "" + Character.HP;
        GameManagerScript.gameManager.Char.GetComponentsInChildren<Text>()[3].text = "" + Character.Description;
        GameManagerScript.gameManager.Char.GetComponentsInChildren<Text>()[4].text = "" + Character.Name;
        GameManagerScript.gameManager.Designer.GetComponent<Image>().sprite = Character.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 