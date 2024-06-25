using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // �̵� �ӵ�

    void Update()
    {
        // ����Ű �Է��� �޽��ϴ�.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // �̵� ������ ����մϴ�.
        Vector3 moveDirection = new Vector3(moveHorizontal, moveVertical, 0);

        // �̵��� �����մϴ�.
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
