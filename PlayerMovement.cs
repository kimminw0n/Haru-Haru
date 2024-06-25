using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // 이동 속도

    void Update()
    {
        // 방향키 입력을 받습니다.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 이동 방향을 계산합니다.
        Vector3 moveDirection = new Vector3(moveHorizontal, moveVertical, 0);

        // 이동을 적용합니다.
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
