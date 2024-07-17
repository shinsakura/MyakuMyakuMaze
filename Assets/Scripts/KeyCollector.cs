using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCollector : MonoBehaviour
{
    public GameObject lastDoor; // �Ō�̃h�A��GameObject���i�[����ϐ�
    private int keysCollected = 0; // �W�߂����̐����Ǘ�����ϐ�
    [SerializeField] Animator animator2;

    //public Text keysCollectedText; // ���̐���\�����邽�߂̃e�L�X�gUI

    private void Start()
    {
        // �Ō�̃h�A��GameObject����
        lastDoor = GameObject.FindGameObjectWithTag("lastDoor");

        // ���̐���\������e�L�X�g��������
        //keysCollectedText.text = $"��: {keysCollected} / 3";
    }

    public void CollectKey()
    {
        keysCollected++;
        //keysCollectedText.text = $"��: {keysCollected} / 3";

        // 3�̌����W�߂���A�Ō�̃h�A���J��
        if (keysCollected == 3)
        {
            animator2.SetTrigger("lastDoorOpen");
            Debug.Log("�Ō�̃h�A���J���܂���!");
            //Destroy(lastDoor);
        }

    }

    private void Update()
    {
    }
}