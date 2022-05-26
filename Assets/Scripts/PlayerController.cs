using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_movementSpeed;
    private float m_defaultMovementSpeed;
    public float m_sprintingMovementSpeed;
    public bool m_isSprinting;

    public float m_lookSpeed;
    private float m_lookXLimit = 85f;

    public Camera m_camera;
    CharacterController m_cc;

    // Start is called before the first frame update
    void Start()
    {
        m_cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        m_camera.transform.rotation = Quaternion.Euler(Vector3.zero);
        m_defaultMovementSpeed = m_movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            m_movementSpeed = m_sprintingMovementSpeed;
        }
        else
        {
            m_movementSpeed = m_defaultMovementSpeed;
        }
        
        m_cc.Move(transform.forward * Input.GetAxis("Vertical") * m_movementSpeed * Time.deltaTime);
        m_cc.Move(transform.right * Input.GetAxis("Horizontal") * m_movementSpeed * Time.deltaTime);

        m_cc.SimpleMove(Physics.gravity);

        m_camera.transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * m_lookSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * m_lookSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {

    }
    public bool IsSprinting()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
