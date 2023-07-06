using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    //���� �ٵ�� ���ǵ�, �Ҹ�, ������ ����
    public GameObject bulletPrefab = default;
    private Rigidbody playerRigid = default;
    public float speed = 15;
    public float PlayerLife = default;

    // Start is called before the first frame update
    void Start()
    {
        //�����ٵ� ��������
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� �����̴� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigid.velocity = newVelocity;

        if(Input.GetKeyDown(KeyCode.Z))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        }

    }   //Update()

    public void Die()
    {
        PlayerLife -= 1;
        if (PlayerLife <= 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            /*Pass*/
        }    
        //GameManager gameManager = FindObjectOfType<GameManager>();
        //gameManager.EndGame();
    }
}
