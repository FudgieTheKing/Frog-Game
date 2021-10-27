using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class triggering : MonoBehaviour
{
    public TextMeshProUGUI pointsCounter;
    public string wining = "win";
    public Transform player;
    bool points = true;
    public int playerPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (points)
        {
            playerPoints = (int)player.transform.position.z;
            pointsCounter.text = "Points: " + playerPoints.ToString();
        }

    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            points = false;
            StartCoroutine(ExampleCoroutine());
        }
           
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("lol");
        pointsCounter.text = wining;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
