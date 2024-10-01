using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public abstract class SpellCard : Card
{
    public EntitySO Entity;
    // Start is called before the first frame update
    public void AssignInfo()
    {
        GameManagerScript.gameManager.Spell.GetComponentsInChildren<Text>()[0].text = "" + Mana;
        GameManagerScript.gameManager.Spell.GetComponentsInChildren<Text>()[1].text = "" + Entity.Description;
        GameManagerScript.gameManager.Spell.GetComponentsInChildren<Text>()[2].text = "" + Entity.Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
