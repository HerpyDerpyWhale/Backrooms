using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingEyes : MonoBehaviour
{
    public GameObject m_player;
    public Renderer m_renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(m_player.transform.position);
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

}
