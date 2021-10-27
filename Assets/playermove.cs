using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playermove : MonoBehaviour
{
    Vector3 vel;
    public float grav = -9.81f;
    public CharacterController control;
    public float speed = 5f;
    private bool isGrounded;
    public Transform groundcheck;
    private float grounddist = .4f;
    public LayerMask groundmask;
    public float jumpHeight = 3f;
    public GameObject me;
    public TextMeshProUGUI pointsCounter;
   
    public int playerPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        isGrounded = Physics.CheckSphere(groundcheck.position, grounddist, groundmask);

        Vector3 move = transform.right * x + transform.forward * z;
        control.Move(move * speed * Time.deltaTime);
        vel.y += grav * Time.deltaTime;
        control.Move(vel * Time.deltaTime);

        if ((isGrounded && vel.y < 0))
        {
            vel.y = -2;
        }

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "win") //
        {
            

        }
        if (collision.gameObject.tag == "destroy")
        {
            Destroy(me);
        }

        if (collision.gameObject.tag == "enemy") //
        {
            Restart();

        }





    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
