using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	public bool grounded = false;
	public bool isjumping = false;
	public bool midJump = false;
	public bool carryingObject = false;
    public float jumptimer = 0;

    public bool rooted;

    public float gravity = 3f;

	public int moveSpeed = 5;

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

    public Vector3 direction;

    // Use this for initialization
    void Start () {
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

<<<<<<< HEAD
        for (int num = 0; num <= 2; num++)
        {
            if(num == 0)
            {
                current = gamemanager.SelectedRedAbility1;
            }
            else if(num == 1)
            {
                current = gamemanager.SelectedRedAbility2;
            }
            else if(num == 2)
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
            if (current == "Flame Dash")
            {
                gameObject.GetComponentInChildren<red3>().enabled = true;

                gameObject.GetComponentInChildren<red3>().buttonid = num;
            }
            if (current == "Burning Pillar")
            {
                gameObject.GetComponentInChildren<red4>().enabled = true;

                gameObject.GetComponentInChildren<red4>().buttonid = num;
            }
        }

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
=======
        //Ability Init
        RedAbilitiesInit();
        BlueAbilitiesInit();
        WeaponsInit();
>>>>>>> 44ef82c64b37b074bdb3c81cc8ed7ac907c4e05d

    }

    // Update is called once per frame
    void Update()
    {

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
            jumptimer = 0;
            antiGrav = 10;
        }

        //Movement
        if (!rooted)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                transform.eulerAngles = new Vector3(0, -180, 0);
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
            antiGrav = 10;

            if (!midJump)
            {
                transform.Translate(Vector3.up * antiGrav * Time.deltaTime);
            }
            else gravity = 4f;
            jumptimer += Time.deltaTime;
            if (jumptimer >= .25 && jumptimer <= .55 && midJump == false)
            {
                midJump = true;
            }
        }
    }


    }

    void OnCollisionEnter(Collision other) {
        
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

    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("redfloor"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            grounded = false;
        }
    }

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
            if (current == "Flame Dash")
            {
                gameObject.GetComponentInChildren<red3>().enabled = true;

                gameObject.GetComponentInChildren<red3>().buttonid = num;
            }
            if (current == "Burning Pillar")
            {
                gameObject.GetComponentInChildren<red4>().enabled = true;

                gameObject.GetComponentInChildren<red4>().buttonid = num;
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

            if (current == "Cone of Cold")
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

        }
    }

    void WeaponsInit()  
    {
        if(gamemanager.SelectedRedWeapon == "bow")
        {
            gameObject.GetComponentInChildren<bow>().enabled = true;
            gameObject.GetComponentInChildren<bow>().weaponred = true;
        }
        else if(gamemanager.SelectedRedWeapon == "sword")
        {
            gameObject.GetComponentInChildren<sword>().enabled = true;
            gameObject.GetComponentInChildren<sword>().weaponred = true;
        }

        if (gamemanager.SelectedBlueWeapon == "bow")
        {
            gameObject.GetComponentInChildren<bow>().enabled = true;
            gameObject.GetComponentInChildren<bow>().weaponred = false;
        }
        else if (gamemanager.SelectedBlueWeapon == "sword")
        {
            gameObject.GetComponentInChildren<sword>().enabled = true;
            gameObject.GetComponentInChildren<sword>().weaponred = false;
        }

    }
}
