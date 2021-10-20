using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class AlienMoviment : MonoBehaviour
{
    [SerializeField] private float m_Speed = 5f;
    [SerializeField] private bool m_Grounded = false;
    [SerializeField] private float m_JumpSpeed = 5f;

    private float m_Pos_y;
    private CharacterController m_CCtrl;

    private Animator m_Anim;

    // Start is called before the first frame update
    void Start()
    {
        m_CCtrl = GetComponent<CharacterController>();
        m_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical_input = Input.GetAxis("Vertical");
        float horizontal_input = Input.GetAxis("Horizontal");
        m_Anim.SetBool("running", (vertical_input != 0) || (horizontal_input != 0));

        transform.Rotate(new Vector3(0,horizontal_input * 180 * Time.deltaTime, 0));
        Vector3 moving_direction = transform.forward * m_Speed * vertical_input;
        m_Grounded = ((m_CCtrl.collisionFlags & CollisionFlags.Below) != 0) || m_CCtrl.isGrounded;
        m_Anim.SetBool("jumping", !m_Grounded);
        if ((m_Grounded) && (Input.GetKeyDown(KeyCode.Space))) {
            m_Pos_y = m_JumpSpeed;
        }
        m_Pos_y += Physics.gravity.y * Time.deltaTime;
        moving_direction.y = m_Pos_y;
        CollisionFlags collisions = m_CCtrl.Move(moving_direction * Time.deltaTime);
    }

    /*
    public void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.collider.gameObject.CompareTag("Box")) {
        }
    }
    */

}
