using System.Collections.Generic;
using UnityEngine;

public class BreakTree : Interactable
{

    [SerializeField] private int health = 5;
    [SerializeField] private List<Sprite> treeSprites;
    [SerializeField] private SpriteRenderer treeSpriteRenderer;

    private int maxHealth;

    void Start()
    {
        maxHealth = health;
        treeSpriteRenderer.gameObject.SetActive(false);
    }

    public override void Interact()
    {
        if (health <= 0) return;

        if (health == maxHealth)
        {
            treeSpriteRenderer.gameObject.SetActive(true);
        }

        health--;
        Debug.Log("Tree health: " + health);
        UpdateSprite();

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void UpdateSprite()
    {
        if (treeSprites == null || treeSprites.Count == 0) return;

        int spriteIndex = (maxHealth - health) * (treeSprites.Count - 1) / maxHealth;
        spriteIndex = Mathf.Clamp(spriteIndex, 0, treeSprites.Count - 1);
        treeSpriteRenderer.sprite = treeSprites[spriteIndex];
    }
}
