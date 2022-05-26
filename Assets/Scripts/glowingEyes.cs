using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowingEyes : MonoBehaviour
{
    private GameObject m_player;
    private SpriteRenderer m_renderer;
    public bool debugStuff;
    
    // Start is called before the first frame update
    void Start()
    {
        m_renderer = GetComponent<SpriteRenderer>();
        m_player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_renderer.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_renderer.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(m_player.transform.position);
        Vector3 direction = m_player.transform.position - transform.position;
        transform.forward = direction;

        if (debugStuff)
        {
            Debug.Log("Forward: " + transform.forward);
        }

    }
}
