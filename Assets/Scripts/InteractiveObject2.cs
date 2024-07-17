using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;



public class PlayAnimationOnClick2 : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator animator1;
    public Button TrueButton;
    private KeyCollector keyCollector;
    public bool GetCosmo = false;


    void Start()
    {
        TrueButton.onClick.AddListener(OnMouseDown);
        keyCollector = GameObject.Find("lastDoor").GetComponent<KeyCollector>();

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        animator.SetTrigger("TreasureBoxOpen2");
        animator1.SetTrigger("CosmoTrigger");
        if (GetCosmo == false)
        {
            keyCollector.CollectKey();
        }
        GetCosmo = true;

        Debug.Log("Object was clicked.");
    }
}
