using UnityEngine;

public class AnimatedSprite : MonoBehaviour
{
    public Sprite[] sprites;

    private SpriteRenderer speriteRenderer;
    private int frame;

    private void Awake()
    {
        speriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Animate), 0f);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
    private void Animate ()
    {
        frame++;

        if (frame >= sprites.Length)
        {
            frame= 0;
        }
        if (frame >= 0 && frame < sprites.Length)
        { 
            speriteRenderer.sprite = sprites[frame];
        }

        Invoke(nameof(Animate), 1f / GameManager.Instance.gameSpeed);
        

    }

}
