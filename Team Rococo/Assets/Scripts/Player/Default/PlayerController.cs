using System.Collections;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;

public class PlayerController : MonoBehaviour
{
    GameObject gPlayer;
    CharacterController cCharacterController;
    RaycastHit rIsGrounded;

    Vector3 vVelocity = new Vector3(0, 0, 0);
    Vector3 vDashDirection = new Vector3(0, 0, 0);
    Vector3 vMoveDirection;

    float vSpeed;
    bool isDash;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cCharacterController = GetComponent<CharacterController>();
        vSpeed = SystemData.I.sPlayerInfo.vMoveSpeed;
        isDash = false;
    }

    private void Update()
    {
        float vInputX = Input.GetAxisRaw("Horizontal");
        float vInputZ = Input.GetAxisRaw("Vertical");

        vMoveDirection = transform.forward * vInputZ + transform.right * vInputX;
        vMoveDirection.y = 0;
        vMoveDirection.Normalize();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += vMoveDirection * vSpeed * Time.deltaTime;
    }

    bool IsGrounded()
    {
        float distanceToGround = 0.2f; // 발 아래로 얼마나 체크할지
        return Physics.Raycast(transform.position, Vector3.down, distanceToGround);
    }
}
