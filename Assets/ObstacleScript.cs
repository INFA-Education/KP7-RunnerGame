using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleScript : MonoBehaviour
{   
    public GameObject player;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
       if (this.transform.position.z < player.transform.position.z)
        {
            PlayerScript.score += 2;
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(0,0,-1000*Time.deltaTime);
    }
}
