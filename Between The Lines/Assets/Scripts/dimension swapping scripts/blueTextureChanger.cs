using UnityEngine;
using System.Collections;

public class blueTextureChanger : MonoBehaviour {
    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    Renderer rend;
    Material solid;
    Material trans;

    // Use this for initialization
    void Start()
    {
        gamecontroller = GameObject.Find("GameController");
        aspects = gamecontroller.GetComponent<aspects>();
        rend = this.GetComponent<MeshRenderer>();
        solid = Resources.Load<Material>("blue/Blue Block");
        trans = Resources.Load<Material>("blue/Blue Trans");
    }

    // Update is called once per frame
    void Update()
    {

        red = aspects.red;
        if (!red)
        {
            rend.material = solid;
        }
        else if (red)
        {
            rend.material = trans;
        }
    }
}
