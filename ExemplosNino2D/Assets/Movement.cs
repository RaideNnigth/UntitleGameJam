using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    #region variables

    [Header("PlayerConfig")]
    [SerializeField]
    float speedwalk;
    [SerializeField]
    float speedRun;
    [SerializeField]
    float speedCrounch;
    [SerializeField]
    float jumpHeight;
    [SerializeField]
    bool inGround;

    //Private
    private Rigidbody2D rb;
    private BoxCollider2D rc;

    private float RealSpeed;

    #endregion

    #region InGroundDetection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Ground")
            inGround = true;
    }
    private void OncollisionExit2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Ground")
            inGround = false;
    }
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rc = GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        #region WalkAndRunControl 
        Vector3 getAxis = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetButton("run"))
        {
            RealSpeed = speedRun;

        }
        else
        {
            RealSpeed = speedwalk;
        }
        transform.position = transform.position + getAxis * RealSpeed;
        #endregion
    }
}
