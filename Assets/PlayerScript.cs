using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerScript playerscript;
    public static int score;
    public Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(score);
        scoretext.text = "Score: " + score.ToString();
    }

    private void FixedUpdate()
    {
        //rb.AddForce(0,0,1000*Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        { 
            rb.transform.Translate(0.3f,0,0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Translate(-0.3f, 0, 0);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            //Debug.Log("A collision has happened!");
            //PlayerScript.score += 2;
            //Debug.Log("Score: " + score);
            //scoretext.text = score.ToString();
            SceneManager.LoadScene("GameOver");
        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            PlayerScript.score += 2;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
            playerscript.enabled = false;
            
        }
    }
    */
}
