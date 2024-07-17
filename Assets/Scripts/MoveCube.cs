using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    [SerializeField] Animator dooropen;

    public void Onjikkou()
    {
        dooropen.SetTrigger("OpenDoor");
    }

    public void Onjikkou2()
    {
        dooropen.SetTrigger("OpenDoor2");
    }

    public void Onjikkou3()
    {
        dooropen.SetTrigger("OpenDoor3");
    }

    // Update is called once per frame
    void Update()
    {

    }
}