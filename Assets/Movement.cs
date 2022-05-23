using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float m_movementSpeed;
    public float m_rotateSpeed;
    public GameObject m_camera;
    CharacterController m_cc;
    
    // Start is called before the first frame update
    void Start()
    {
        m_cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        m_cc.Move(transform.forward * Input.GetAxis("Vertical") * m_movementSpeed * Time.deltaTime);
        m_cc.Move(transform.right * Input.GetAxis("Horizontal") * m_movementSpeed * Time.deltaTime);
        m_cc.SimpleMove(Physics.gravity); 
        m_camera.transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * m_rotateSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * m_rotateSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        
    }
}
