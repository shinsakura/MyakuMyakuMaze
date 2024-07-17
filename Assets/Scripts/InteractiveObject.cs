using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class PlayAnimationOnClick : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator animator1;
    public Button TrueButton;
    private KeyCollector keyCollector;
    public bool GetTaiyo = false;

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
        animator.SetTrigger("TreasureBoxOpen");
        animator1.SetTrigger("TowerTrigger");
        if(GetTaiyo == false)
        {
            keyCollector.CollectKey();
        }
        GetTaiyo = true;
        Debug.Log("Object was clicked.");
    }
}
