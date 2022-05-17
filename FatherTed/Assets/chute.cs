using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chute : MonoBehaviour
{
    public GameObject menuScreen;
    public string name;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Targetable")
        {
            if(col.name == "Player")
            {
                menuScreen.SetActive(true);
                GameObject.Find("Player").transform.position = new Vector3(2, 5, -6);
                PauseGame();
            }
            else
            {
                name = col.name;
            }

            GameObject.Find("Claw").GetComponent<Claw>().ChangeTarget();

        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
