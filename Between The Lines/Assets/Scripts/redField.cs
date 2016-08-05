using UnityEngine;
using System.Collections;

public class redField : MonoBehaviour {

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    Renderer rend;
    Material trans;
    Material red2;

    // Use this for initialization
    void Start()
    {
        gamecontroller = GameObject.Find("GameController");
        aspects = gamecontroller.GetComponent<aspects>();
        rend = this.GetComponent<MeshRenderer>();
        trans = Resources.Load<Material>("Transparent");
        red2 = Resources.Load<Material>("Red RNG");
    }

    // Update is called once per frame
    void Update()
    {

        red = aspects.red;
        if (!red)
        {
            rend.material = trans;
        }
        else if (red)
        {
            rend.material = red2;
        }
    }
}
