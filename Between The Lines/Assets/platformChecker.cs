using UnityEngine;
using System.Collections;

public class platformChecker : MonoBehaviour {

    public GameObject gameManager;
    public aspects aspects;

	// Use this for initialization
	void Start () {
        aspects = gameManager.GetComponent<aspects>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        
        if (aspects.red)
        {

            if (other.CompareTag("bluewall") || other.CompareTag("bluefloor"))
            {
                aspects.canswitch = false;
            }

        }else if (!aspects.red)
        {
            if (other.CompareTag("redwall") || other.CompareTag("redfloor"))
            {
                aspects.canswitch = false;
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name);
        if (aspects.red)
        {

            if (other.CompareTag("bluewall") || other.CompareTag("blueFloor"))
            {
                aspects.canswitch = true;
            }

        }
        else if (!aspects.red)
        {
            if (other.CompareTag("redwall") || other.CompareTag("redFloor"))
            {
                aspects.canswitch = true;
            }
        }
    }

}
