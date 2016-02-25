using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CubeController : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rigid;
    public float speed;

    void Start()
    {
       // run = cube.transform.position;
       rigid = GetComponent<Rigidbody>();
       Debug.Log(rigid);
    }

    void FixedUpdate()
    {
        float distance = Vector3.Distance(player.transform.position, gameObject.transform.position);
        //Vector3 move = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        //Vector3 move = new Vector3(player.GetComponent<Rigidbody>().velocity.x, 0, player.GetComponent<Rigidbody>().velocity.y);
        //Debug.Log(move);

        if (distance < 3f)
        {
            Vector3 move = new Vector3(player.transform.position.x, 0, player.transform.position.z);
            rigid.AddForce(move.normalized / 2f);
            //gameObject.GetComponent<Rigidbody>().velocity = player.GetComponent<Rigidbody>().velocity;
            Debug.Log("distance < 3f");
            //rigid.AddForce(move * speed);
            //Debug.Log(gameObject.GetComponent<Rigidbody>().velocity);

        }

        Debug.Log(rigid);
        
    }
}
