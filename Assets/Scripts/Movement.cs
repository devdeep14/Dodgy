using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    public int count = 3;

    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    void MovePlayer()
    {
        float xValues = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float zValues = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * -1;
        transform.Translate(xValues, 0, zValues);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hit")
        {
            count--;
        }

        if(count == 0)
        {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
