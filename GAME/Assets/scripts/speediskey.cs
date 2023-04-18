using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class speediskey : MonoBehaviour
{
    public chickSkater player;

    public float min_speed = 7f;
    public Rigidbody rb;
    private bool WaitForDelay = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
                  

    void Update()
    {
        float move = Time.deltaTime * min_speed * Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.D) && !WaitForDelay)
        {
            WaitForDelay = true;
            StartCoroutine(MoveFaster());
        }

    }

    private IEnumerator MoveFaster()
    {
        player.moveSpeed = min_speed;
        yield return new WaitForSeconds(1);
        player.moveSpeed = 5f;
        WaitForDelay = false;
    }
}
