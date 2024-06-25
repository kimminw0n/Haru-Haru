using UnityEngine;

public class AvatarAngle : MonoBehaviour
{
    public Sprite upSprite; // 위쪽 방향 스프라이트
    public Sprite downSprite; // 아래쪽 방향 스프라이트
    public Sprite leftSprite; // 왼쪽 방향 스프라이트
    public Sprite rightSprite; // 오른쪽 방향 스프라이트

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // 초기 스프라이트 설정
        spriteRenderer.sprite = downSprite;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            spriteRenderer.sprite = upSprite;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            spriteRenderer.sprite = downSprite;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.sprite = leftSprite;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.sprite = rightSprite;
        }
    }
}
