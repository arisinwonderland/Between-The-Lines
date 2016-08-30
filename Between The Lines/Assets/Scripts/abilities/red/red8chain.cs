using UnityEngine;
using System.Collections;

public class red8chain : MonoBehaviour {

    public GameObject pillar1;
    public GameObject pillar2;

    public float timer;
    // Use this for initialization
    void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        pillar1.transform.Translate(Vector3.right * 10 * Time.deltaTime);
        pillar2.transform.Translate(Vector3.right * 10 * Time.deltaTime);

        if (timer >= 1)
        {
            Destroy(gameObject);
        }
	}
}
