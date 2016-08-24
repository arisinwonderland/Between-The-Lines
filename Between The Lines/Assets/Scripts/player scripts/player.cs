using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	public bool grounded = true;
	public bool isjumping = false;
	public bool midJump = false;
	public bool carryingObject = false;
    public float jumptimer = 0;

    public bool rooted;

    public float gravity = 3f;

	public int moveSpeed = 10;

    public float antiGrav = 10;
    public bool stopped;
    public float Timer;
    public GameObject feets;
    
    public aspects aspects;
    public bool red;

    public GameObject GameManager;
    public gamemanager gamemanager;
    string current;

    public int hp;
    public float redmana;
    public float redmanaregen;
    public float bluemana;
    public float bluemanaregen;



    public GameObject sprite;

    public Animator animator;






    public Vector3 direction;

    public int levelindex;
    // Use this for initialization
    void Start () {
        sprite = GameObject.Find("playerSprite");
        animator = sprite.GetComponent<Animator>();
        direction = Vector3.right;
        Timer = 0;

        rooted = false;

        GameManager = GameObject.Find("gamemanager");
        gamemanager = GameManager.GetComponent<gamemanager>();
        aspects = GameManager.GetComponent<aspects>();

        //Stats
        hp = 100;
        redmana = 100;
        redmanaregen = 5;
        bluemana = 100;
        bluemanaregen = 5;

      

       

        //Ability Init
        RedAbilitiesInit();
        BlueAbilitiesInit();
        WeaponsInit();

    }

    // Update is called once per frame
    void Update()
    {
        //death
        if(hp <= 0)
        {
            gamemanager.loadlevel(levelindex);
        }

        //Mana regen
        if(redmana < 100)
        {
            redmana = redmana + (redmanaregen * Time.deltaTime);
        }
        if(redmana > 100)
        {
            redmana = 100;
        }
        if (bluemana < 100)
        {
            bluemana = bluemana + (bluemanaregen * Time.deltaTime);
        }
        if (bluemana > 100)
        {
            bluemana = 100;
        }

        //Get state
        red = aspects.red;

        //Grounded stuff
        if (grounded)
        {
            jumptimer = 0;
            midJump = false;
            isjumping = false;
            gravity = 4f;
            antiGrav = 10;
        }

        //Movement
        if (!rooted)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                transform.eulerAngles = new Vector3(0, 0, 0);
                animator.SetInteger("animation", 2);
                

            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                transform.eulerAngles = new Vector3(0, -180, 0);
                animator.SetInteger("animation", 2);
                
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animator.SetInteger("animation", 1);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                animator.SetInteger("animation", 1);
            }


            //Jumping
            if (Input.GetKeyDown(KeyCode.Space) && !isjumping)
            {
                if (grounded == true)
                {
                    grounded = false;
                    isjumping = true;
                }
            }
        
        if (isjumping == true)
        {
<<<<<<< HEAD
                
                antiGrav = 10;
=======
>>>>>>> fa0f14d22a735bb4dcaf08f978d4e3e1c225290d

                if (!midJump)
                {
                    transform.Translate(Vector3.up * antiGrav * Time.deltaTime);
                    animator.SetInteger("animation", 5);
                }
                else
                {
                    gravity = 4f;
                    animator.SetInteger("animation", 6);
                }
            jumptimer += Time.deltaTime;
            if (jumptimer >= .25 && jumptimer <= .70 && midJump == false)
            {
                midJump = true;
            }
        }
    }


    }

<<<<<<< HEAD
    void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("Floor"))
        {
            animator.SetInteger("animation", 1);
            grounded = true;
            isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }

        else if (other.gameObject.CompareTag("redfloor"))
        {
            animator.SetInteger("animation", 1);
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            animator.SetInteger("animation", 1);
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            animator.SetInteger("animation", 1);
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            animator.SetInteger("animation", 1);
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        } else grounded = false;

    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }

        else if (other.gameObject.CompareTag("redfloor"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;

            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }
        else grounded = false;
=======
>>>>>>> fa0f14d22a735bb4dcaf08f978d4e3e1c225290d



    void RedAbilitiesInit()
    {
        for (int num = 0; num <= 2; num++)
        {
            if (num == 0)
            {
                current = gamemanager.SelectedRedAbility1;
            }
            else if (num == 1)
            {
                current = gamemanager.SelectedRedAbility2;
            }
            else if (num == 2)
            {
                current = gamemanager.SelectedRedAbility3;
            }

            if (current == "Firebolt")
            {
                gameObject.GetComponentInChildren<red1>().enabled = true;

                gameObject.GetComponentInChildren<red1>().buttonid = num;
            }
            if (current == "Surge of Flame")
            {
                gameObject.GetComponentInChildren<red2>().enabled = true;

                gameObject.GetComponentInChildren<red2>().buttonid = num;
            }
            if (current == "Obsidian Rush")
            {
                gameObject.GetComponentInChildren<red3>().enabled = true;

                gameObject.GetComponentInChildren<red3>().buttonid = num;
            }
            if (current == "Pillar of Flame")
            {
                gameObject.GetComponentInChildren<red4>().enabled = true;

                gameObject.GetComponentInChildren<red4>().buttonid = num;
            }
            if (current == "Hellfire")
            {
                gameObject.GetComponentInChildren<red5>().enabled = true;

                gameObject.GetComponentInChildren<red5>().buttonid = num;
            }
        }
    }   

    void BlueAbilitiesInit()
    {
        for (int num = 0; num <= 2; num++)
        {
            if (num == 0)
            {
                current = gamemanager.SelectedBlueAbility1;
            }
            else if (num == 1)
            {
                current = gamemanager.SelectedBlueAbility2;
            }
            else if (num == 2)
            {
                current = gamemanager.SelectedBlueAbility3;
            }

            if (current == "Cone Of Cold")
            {
                gameObject.GetComponentInChildren<blue1>().enabled = true;

                gameObject.GetComponentInChildren<blue1>().buttonid = num;
            }
            if (current == "Soaring Hope")
            {
                gameObject.GetComponentInChildren<blue2>().enabled = true;

                gameObject.GetComponentInChildren<blue2>().buttonid = num;
            }
            if (current == "Guardian Blade")
            {
                gameObject.GetComponentInChildren<blue3>().enabled = true;

                gameObject.GetComponentInChildren<blue3>().buttonid = num;
            }
            if (current == "Ice Blast")
            {
                gameObject.GetComponentInChildren<blue4>().enabled = true;

                gameObject.GetComponentInChildren<blue4>().buttonid = num;
            }
            if (current == "Arctic Circle")
            {
                gameObject.GetComponentInChildren<blue5>().enabled = true;

                gameObject.GetComponentInChildren<blue5>().buttonid = num;
            }
        }
    }

    void WeaponsInit()  
    {
        if(gamemanager.SelectedRedWeapon == "Bow")
        {
            gameObject.GetComponentInChildren<bow>().enabled = true;
            gameObject.GetComponentInChildren<bow>().weaponred = true;
        }
        else if(gamemanager.SelectedRedWeapon == "Sword")
        {
            gameObject.GetComponentInChildren<sword>().enabled = true;
            gameObject.GetComponentInChildren<sword>().weaponred = true;
        }

        if (gamemanager.SelectedBlueWeapon == "Bow")
        {
            gameObject.GetComponentInChildren<bow>().enabled = true;
            gameObject.GetComponentInChildren<bow>().weaponred = false;
        }
        else if (gamemanager.SelectedBlueWeapon == "Sword")
        {
            gameObject.GetComponentInChildren<sword>().enabled = true;
            gameObject.GetComponentInChildren<sword>().weaponred = false;
        }

    }
}
