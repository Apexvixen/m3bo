using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;

    points myPoints;
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        myPoints = player.GetComponent<points>();
       // myPoints = FindObjectOfType<points>();

    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yes");
         if(other.gameObject.tag == "Player") 
        {
            myPoints.Points++;
            GameObject explosion = Instantiate(particle);
            explosion.transform.position = gameObject.transform.position;

            Destroy(gameObject);

            Destroy(explosion, 0.5f);



        }
    }
}