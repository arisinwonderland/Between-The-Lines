using UnityEngine;
using System.Collections;

public class redTextureChanger : MonoBehaviour {
    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    Renderer rend;
    Material solid;
    Material trans;

	// Use this for initialization
	void Start () {
        gamecontroller = GameObject.Find("gamemanager");
        aspects = gamecontroller.GetComponent<aspects>();
        rend = this.GetComponent<MeshRenderer>();
        solid = Resources.Load<Material>("red/Red Block");
        trans = Resources.Load<Material>("red/Red Trans");
    }
	
	// Update is called once per frame
	void Update () {
 
        red = aspects.red;
        if (red)
        {
            rend.material = solid;
        }else if (!red)
        {
            rend.material = trans;
        }
    }
}
