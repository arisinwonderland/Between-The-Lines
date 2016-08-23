using UnityEngine;
using System.Collections;

public class testEnemy: enemyDamage{

    public GameObject player = GameObject.FindGameObjectWithTag("Player");
    public float distance;
    public Transform myTransform;
    public float moveSpeed;

    void Start()
    {
        myTransform = gameObject.transform;
        moveSpeed = 3;
    }


    // Update is called once per frame
    void Update () {
        
        distance = Vector3.Distance(transform.position, player.transform.position);
        if(distance <= 15)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(player.transform.position - myTransform.position), 15 * Time.deltaTime);
            myTransform.rotation.Set(0, myTransform.rotation.y, 0, myTransform.rotation.w);
        }
        if (distance <= 5)
        {
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
    }

    void followPlayer(float distance)
    {
        
    }
}
