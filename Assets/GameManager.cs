using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject player;
    public GameObject pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObstacle", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            pausemenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
    void InstantiateObstacle()
    {
        Instantiate(obstacle, new Vector3(Random.Range(-4f, 4f), -2.8f, player.transform.position.z + 15), transform.rotation);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1;
    }
}
