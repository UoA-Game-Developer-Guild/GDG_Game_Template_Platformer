using System.Collections.Generic;
using UnityEngine;

public class BreakTree : Interactable
{

    [SerializeField] private int health = 5;
    
    public override void Interact()
    {
        if (health > 0)
        {
            health--;
            Debug.Log("Tree health: " + health);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
