using UnityEngine;

public class AvatarAngle : MonoBehaviour
{
    public Sprite upSprite; // ���� ���� ��������Ʈ
    public Sprite downSprite; // �Ʒ��� ���� ��������Ʈ
    public Sprite leftSprite; // ���� ���� ��������Ʈ
    public Sprite rightSprite; // ������ ���� ��������Ʈ

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // �ʱ� ��������Ʈ ����
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
