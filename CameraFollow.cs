using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform�� ����
    public Vector2 offset; // �÷��̾�� ī�޶� ������ ������

    private void LateUpdate()
    {
        // ī�޶��� z �� ��ġ�� �����Ͽ� 2D ���������� ��ġ�� ����
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
    }
}
