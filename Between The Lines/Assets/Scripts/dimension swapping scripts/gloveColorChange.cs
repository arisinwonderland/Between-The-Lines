using UnityEngine;
using System.Collections;

public class gloveColorChange : MonoBehaviour {

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    Renderer rend;
    Material blue;
    Material red2;

    // Use this for initialization
    void Start()
    {
        gamecontroller = GameObject.Find("GameController");
        aspects = gamecontroller.GetComponent<aspects>();
        rend = this.GetComponent<MeshRenderer>();
        blue = Resources.Load<Material>("blue/Blue Block");
        red2 = Resources.Load<Material>("red/Red Block");
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
            rend.material = red2;
        }
    }
}
