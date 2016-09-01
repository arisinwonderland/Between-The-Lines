using UnityEngine;
using System.Collections;

public class moving2pts : MonoBehaviour
{

    public GameObject pt1;
    public GameObject pt2;
    int state;

    // Use this for initialization
    void Start()
    {
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (state == 0)
        {

            transform.position = Vector3.MoveTowards(transform.position, pt2.transform.position, .05f);

            if ((transform.position - pt2.transform.position).sqrMagnitude <= 1f)
            {
                state = 1;
                transform.eulerAngles = new Vector3(0,180,0);
            }
        }else if (state == 1){

                transform.position = Vector3.MoveTowards(transform.position, pt1.transform.position, .05f);

                if (transform.position == pt1.transform.position)
                {
                    state = 0;
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            }
        
    }
}
