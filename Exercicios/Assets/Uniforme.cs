using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uniforme : MonoBehaviour
{
    public Transform finalpoint;
    public float velocidade =5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (finalpoint.position - transform.position).normalized*velocidade*Time.deltaTime;
    }
}
