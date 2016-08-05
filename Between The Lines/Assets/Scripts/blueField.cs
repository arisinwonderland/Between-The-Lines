using UnityEngine;
using System.Collections;

public class blueField : MonoBehaviour {

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    Renderer rend;
    Material trans;
    Material blue;

    // Use this for initialization
    void Start()
    {
        gamecontroller = GameObject.Find("GameController");
        aspects = gamecontroller.GetComponent<aspects>();
        rend = this.GetComponent<MeshRenderer>();
        trans = Resources.Load<Material>("Transparent");
        blue = Resources.Load<Material>("Blue NRG");
    }

    // Update is called once per frame
    void Update()
    {

        red = aspects.red;
        if (!red)
        {
            rend.material = blue;
        }
        else if (red)
        {
            rend.material = trans;
        }
    }
}
