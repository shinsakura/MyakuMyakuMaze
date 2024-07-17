using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;



public class PlayAnimationOnClick1 : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator animator1;
    public Button TrueButton;
    private KeyCollector keyCollector;
    public bool GetKumudori = false;


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
        animator.SetTrigger("TreasureBoxOpen1");
        animator1.SetTrigger("KumudoriTrigger");
        if(GetKumudori == false) {
            keyCollector.CollectKey();
        }
        GetKumudori = true;

        Debug.Log("Object was clicked.");
    }
}
