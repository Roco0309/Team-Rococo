using System.Collections;

using UnityEngine;
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

    // Update is called once per frame
    void FixedUpdate()
    {
        float vInputX = Input.GetAxisRaw("Horizontal");
        float vInputZ = Input.GetAxisRaw("Vertical");

        if(!isDash)
        {
            vMoveDirection = new Vector3(vInputX, 0, vInputZ).normalized * vSpeed;
        }

        cCharacterController.Move(vMoveDirection * Time.deltaTime);

        if (IsGrounded() && vVelocity.y < 0)
        {
            vVelocity.y = -2f;
            Debug.Log(IsGrounded());
        }
        vVelocity.y += Physics.gravity.y * Time.deltaTime;

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            vVelocity.y = Mathf.Sqrt(-2f * Physics.gravity.y * SystemData.I.sPlayerInfo.vJumpPower);
        } else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Dash();
        }
        vVelocity.y += Physics.gravity.y * Time.deltaTime;
        cCharacterController.Move(vVelocity * Time.deltaTime);
    }

    bool IsGrounded()
    {
        float distanceToGround = 0.2f; // 발 아래로 얼마나 체크할지
        return Physics.Raycast(transform.position, Vector3.down, distanceToGround);
    }

    IEnumerator Dash()
    {
        isDash = true;
        vSpeed = SystemData.I.sPlayerInfo.vDashSpeed;
        yield return new WaitForSeconds(0.2f);
        vSpeed = SystemData.I.sPlayerInfo.vMoveSpeed;
        isDash = false;
    }
}
