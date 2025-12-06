using UnityEngine;

public class HW3ASettingSprite : MonoBehaviour
{
    public Sprite newSprite;
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = newSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
