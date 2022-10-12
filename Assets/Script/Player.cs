using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController myController;
    public float speed = 2f;
    // Start is called before the first frame update

    private void Awake()
    {
        myController = GetComponent<CharacterController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myController.Move(Vector3.forward * speed);
    }
}
