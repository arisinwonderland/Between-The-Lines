using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {

    public GameObject holder;
    float Timer;
    public float swordCd;
    public float swordTimer;
    public bool onCd;
    public float holdX;
    public float holdY;
    public float holdZ;

    // Use this for initialization
    void Start () {
        Timer = 0;
        swordCd = 2;
        //gameObject.transform.parent = holder.transform;
        //transform.position = holder.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;
        holdX = holder.transform.position.x;
        holdY = holder.transform.position.y;
        holdZ = holder.transform.position.z;
        transform.position = holder.transform.position;
        transform.rotation = holder.transform.rotation;
        gameObject.transform.rotation.Set(holder.transform.rotation.x, holder.transform.rotation.y, holder.transform.rotation.z, holder.transform.rotation.w);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!onCd)
            {
                swordTimer = swordCd;
                onCd = true;
            }
        }
        if (onCd)
        {
            swordTimer -= Time.deltaTime;
            if (swordTimer <= 0)
            {
                onCd = false;
                swordTimer = 0;
            }
        }
    }
}
