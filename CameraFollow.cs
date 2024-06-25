using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform을 참조
    public Vector2 offset; // 플레이어와 카메라 사이의 오프셋

    private void LateUpdate()
    {
        // 카메라의 z 축 위치를 고정하여 2D 공간에서의 위치를 설정
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
    }
}
