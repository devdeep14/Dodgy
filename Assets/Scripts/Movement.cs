using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
