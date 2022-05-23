using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowingEyes : MonoBehaviour
{
    public GameObject m_glowingEyes;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        m_glowingEyes.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        m_glowingEyes.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
