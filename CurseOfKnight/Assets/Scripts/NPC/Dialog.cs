using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public GameObject WindowDialog;
    public TMP_Text textDialog;
    public Button NextButtonDialog;

    public string[] message;
    private int numberDialog = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(numberDialog == message.Length - 1)
            {
                NextButtonDialog.gameObject.SetActive(false);
            }
            else
            {
                NextButtonDialog.gameObject.SetActive(true);
                NextButtonDialog.onClick.AddListener(NextDialog);
            }

            WindowDialog.SetActive(true);
            textDialog.text = message[numberDialog];
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        WindowDialog.SetActive(false);
        NextButtonDialog.onClick.RemoveAllListeners();
        numberDialog = 0;
    }

    public void NextDialog()
    {
        numberDialog++;
        textDialog.text = message[numberDialog];
        if(numberDialog == message.Length - 1)
        {
            NextButtonDialog.gameObject.SetActive(false);
        }
    }
}
